using UnityEngine;
using System.Collections.Generic;

public class Roster : Singleton<Roster>
{
    [SerializeField] private List<Job> roster;

    [SerializeField] private GameObject playerObj;
    [SerializeField] private GameObject tankRoster;
    [SerializeField] private GameObject meleeRoster;
    [SerializeField] private GameObject rangedRoster;
    [SerializeField] private GameObject healerRoster;


    public void AddMelee()
    {
        
    }

    public void AddToRoster(Enums.Class cl, Enums.Roll role, Enums.Range range, Enums.Armor armor)
    {
        Job job = new Job();
        job.jobClass = cl;
        job.role = role;
        job.range = range;
        job.armor = armor;

        roster.Add(job);
    }
}
