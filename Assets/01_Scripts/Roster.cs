using UnityEngine;
using System.Collections.Generic;

public class Roster : Singleton<Roster>
{
    [SerializeField] private List<Job> roster;

    public void AddMelee()
    {
        
    }

    public void AddToRoster(Enums.Class cl)
    {
        Job job = new Job();
        job.jobClass = cl;

        roster.Add(job);
    }
}
