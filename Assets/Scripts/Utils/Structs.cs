using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public struct Vector3SaveData
{
    public float X;
    public float Y;
    public float Z;

    public Vector3SaveData(Vector3 vector3)
    {
        X = vector3.x;
        Y = vector3.y;
        Z = vector3.z;
    }

    public Vector3 ToVector3() => new(X, Y, Z);
}

[Serializable]
public struct QuestSaveData
{
    public string QuestId;
    public QuestState State;
    public Dictionary<string, int> Targets;
}

[Serializable]
public struct StatusSaveData
{
    public int Level;
    public int HP;
    public int MP;
    public int XP;
    public int Gold;
    public int SkillPoint;
}

[Serializable]
public struct QuickSaveData
{
    public ItemSaveData? ItemSaveData;
    public SkillSaveData? SkillSaveData;
    public int Index;
}

[Serializable]
public struct SkillSaveData
{
    public string SkillId;
    public int Level;
}

[Serializable]
public struct ItemSaveData
{
    public string ItemId;
    public int Count;
    public int Index;
}

[Serializable]
public struct SettingsSaveData
{
    public float BGMVolume;
    public float EffectVolume;
    public int MSAA;
    public int Frame;
    public int VSync;
}
