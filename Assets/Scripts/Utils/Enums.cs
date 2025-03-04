
public enum Category
{
    Scene,
    Item,
    Skill,
    Quest,
    NPC,
    Monster,
}

public enum QuestState
{
    Inactive,
    Active,
    Completable,
    Complete,
}

public enum SkillType
{
    Active,
    Passive,
}

public enum SlotType
{
    Item,
    Equipment,
    Quick,
    Skill,
    Shop,
    Reward,
}

public enum EquipmentType
{
    Helmet,
    Chest,
    Pants,
    Boots,
    Weapon,
    Shield,
}

public enum ItemType
{
    Equipment,
    Consumable,
    Etc
}

public enum ItemQuality
{
    Low,
    Middle,
    High,
}

public enum UIType
{
    Subitem,
    Background,
    Auto,
    Fixed,
    Popup,
    Top = 1000,
}

public enum SoundType
{
    BGM,
    Effect
}

public enum SceneType
{
    Unknown,
    LoadingScene,
    MainMenuScene,
    VillageScene,
    DungeonScene,
}

public enum AddressableLabel
{
    Default,
    MainMenu_UI,
    Game_Prefab,
    Game_UI,
}
