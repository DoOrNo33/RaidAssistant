using UnityEngine;
using System.Collections.Generic;

public class Roster : Singleton<Roster>
{
    public List<Job> roster = new List<Job>();
    public void AddMelee()
    {
        
    }
}

public class Job
{
    public string name;
    public Enums.Roll role;
    public Enums.Range range;
    public Enums.Armor armor;
    public Enums.Class jobClass;
}