using UnityEngine;

[System.Serializable]
public class Job
{
    public string name;
    public Enums.Roll role;
    public Enums.Range range;
    public Enums.Armor armor;
    public Enums.Class jobClass;
    public Enums.ClassTalent classTalent;
    public GameObject AssociatedObject;
}
