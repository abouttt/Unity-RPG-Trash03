using System;
using UnityEngine;
using Newtonsoft.Json.Linq;

public class PlayerStatus : MonoBehaviour, ISavable
{
    public static string SaveKey => "SaveStatus";

    public event Action LevelChanged;
    public event Action HPChanged;
    public event Action MPChanged;
    public event Action SPChanged;
    public event Action XPChanged;
    public event Action StatChanged;
    public event Action GoldChanged;
    public event Action SkillPointChanged;

    public int Level { get; private set; } = 1;

    public int HP
    {
        get => _currentStats.HP;
        set
        {
            _currentStats.HP = Mathf.Clamp(value, 0, _maxStats.HP);
            HPChanged?.Invoke();
        }
    }

    public int MP
    {
        get => _currentStats.MP;
        set
        {
            _currentStats.MP = Mathf.Clamp(value, 0, _maxStats.MP);
            MPChanged?.Invoke();
        }
    }

    public float SP
    {
        get => _currentStats.SP;
        set
        {
            float prevSP = _currentStats.SP;
            _currentStats.SP = Mathf.Clamp(value, 0f, _maxStats.SP);
            if (_currentStats.SP < prevSP)
            {
                _recoverySPDeltaTime = 0f;
            }

            SPChanged?.Invoke();
        }
    }

    public int XP
    {
        get => _currentStats.XP;
        set
        {
            if (IsMaxLevel || _maxStats.XP == 0)
            {
                return;
            }

            _currentStats.XP = value;

            int level = 0;
            while (_currentStats.XP >= _maxStats.XP)
            {
                _currentStats.XP -= _maxStats.XP;
                level++;
            }

            if (level > 0)
            {
                LevelUp(level);
            }

            XPChanged?.Invoke();
        }
    }

    public BasicStats FixedStats
    {
        get => _fixedStats;
        set
        {
            _fixedStats = value;
            RefreshAllStats();
            FillMeleeStats();
            StatChanged?.Invoke();
        }
    }

    public BasicStats PercentageStats
    {
        get => _percentageStats;
        set
        {
            _percentageStats = value;
            RefreshAllStats();
            FillMeleeStats();
            StatChanged?.Invoke();
        }
    }

    public int Gold
    {
        get => _gold;
        set
        {
            _gold = value;
            GoldChanged?.Invoke();
        }
    }

    public int SkillPoint
    {
        get => _skillPoint;
        set
        {
            _skillPoint = value;
            SkillPointChanged?.Invoke();
        }
    }

    public int Damage => _currentStats.Damage;
    public int Defense => _currentStats.Defense;

    public bool IsMaxLevel => Level >= _playerStatsTable.StatsTable.Count;
    public int MaxHP => _maxStats.HP;
    public int MaxMP => _maxStats.MP;
    public int MaxSP => (int)_maxStats.SP;
    public int MaxXP => _maxStats.XP;
    public int MaxDamage => _maxStats.Damage;
    public int MaxDefense => _maxStats.Defense;

    [SerializeField]
    private PlayerStatsTable _playerStatsTable;

    [SerializeField]
    private float _recoverySPDelay;

    [SerializeField]
    private float _recoverySPAmount;

    private readonly PlayerStats _maxStats = new();
    private readonly PlayerStats _currentStats = new();
    private BasicStats _fixedStats = new();
    private BasicStats _percentageStats = new();

    private int _gold;
    private int _skillPoint;
    private float _recoverySPDeltaTime; // SP 회복 현재 딜레이 시간

    private void Awake()
    {
        Load();
        RefreshAllStats();
        FillMeleeStats();
        if (Managers.Data.HasSaveData)
        {
            SP = _maxStats.SP;
        }
        else
        {
            FillAbilityStats();
        }

        Player.EquipmentInventory.InventoryChanged += equipmentType =>
        {
            RefreshAllStats();
            FillMeleeStats();
            _currentStats.HP = Mathf.Clamp(_currentStats.HP, _currentStats.HP, _maxStats.HP);
            _currentStats.MP = Mathf.Clamp(_currentStats.MP, _currentStats.MP, _maxStats.MP);
            _currentStats.SP = Mathf.Clamp(_currentStats.SP, _currentStats.SP, _maxStats.SP);
            StatChanged?.Invoke();
        };
    }

    private void Start()
    {
        StatChanged?.Invoke();
    }

    private void Update()
    {
        RecoverySP(Time.deltaTime);
    }

    public JToken GetSaveData()
    {
        var statusSaveData = new StatusSaveData()
        {
            Level = Level,
            HP = _currentStats.HP,
            MP = _currentStats.MP,
            XP = _currentStats.XP,
            Gold = Gold,
            SkillPoint = SkillPoint,
        };

        return new JArray(JObject.FromObject(statusSaveData));
    }

    private void RefreshAllStats()
    {
        int level = (IsMaxLevel ? _playerStatsTable.StatsTable.Count : Level) - 1;

        _maxStats.HP = _playerStatsTable.StatsTable[level].HP;
        _maxStats.MP = _playerStatsTable.StatsTable[level].MP;
        _maxStats.SP = _playerStatsTable.StatsTable[level].SP;
        _maxStats.XP = _playerStatsTable.StatsTable[level].XP;
        _maxStats.Damage = _playerStatsTable.StatsTable[level].Damage;
        _maxStats.Defense = _playerStatsTable.StatsTable[level].Defense;

        _maxStats.BasicStats += _fixedStats;
        _maxStats.BasicStats += Player.EquipmentInventory.GetFixedStats();
        _maxStats.CalcPercentageStats(_percentageStats);
        _maxStats.CalcPercentageStats(Player.EquipmentInventory.GetPercentageStats());
    }

    private void FillAllStats()
    {
        FillAbilityStats();
        FillMeleeStats();
    }

    private void FillAbilityStats()
    {
        _currentStats.HP = _maxStats.HP;
        _currentStats.MP = _maxStats.MP;
        _currentStats.SP = _maxStats.SP;
    }

    private void FillMeleeStats()
    {
        _currentStats.Damage = _maxStats.Damage;
        _currentStats.Defense = _maxStats.Defense;
    }

    private void LevelUp(int level)
    {
        if (level <= 0)
        {
            return;
        }

        Level += level;
        RefreshAllStats();
        FillAllStats();
        Managers.Resource.Instantiate("LevelUpCylinderBlue.prefab", transform.position, transform, true);
        LevelChanged?.Invoke();
        StatChanged?.Invoke();
    }

    // SP 딜레이 시간이 넘으면 SP회복
    private void RecoverySP(float deltaTime)
    {
        if (!Player.Movement.IsGrounded)
        {
            _recoverySPDeltaTime = 0f;
            return;
        }

        _recoverySPDeltaTime += deltaTime;
        if (_recoverySPDeltaTime >= _recoverySPDelay)
        {
            if (SP < _maxStats.SP)
            {
                SP += Mathf.Clamp(_recoverySPAmount * deltaTime, 0f, _maxStats.SP);
            }
        }
    }

    public void Load()
    {
        if (!Managers.Data.Load<JArray>(SaveKey, out var saveData))
        {
            return;
        }

        var statusSaveData = saveData[0].ToObject<StatusSaveData>();

        Level = statusSaveData.Level;
        _gold = statusSaveData.Gold;
        _skillPoint = statusSaveData.SkillPoint;
        _currentStats.HP = statusSaveData.HP;
        _currentStats.MP = statusSaveData.MP;
        _currentStats.XP = statusSaveData.XP;
    }
}
