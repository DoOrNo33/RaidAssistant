using UnityEngine;
using System.Collections.Generic;

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

    // 동일성 판정을 위한 추가 요소
    public override bool Equals(object obj)
    {
        if (obj is Job otherJob)
        {
            return this.name == otherJob.name &&
                   this.role == otherJob.role &&
                   this.range == otherJob.range &&
                   this.armor == otherJob.armor &&
                   this.jobClass == otherJob.jobClass &&
                   this.classTalent == otherJob.classTalent;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return (name, role, range, armor, jobClass, classTalent).GetHashCode();
    }
}

// List<Job>를 감싸는 클래스를 추가
// JsonUtility는 제네릭 타입을 지원하지 않으므로, 데이터를 감싸는 클래스가 필요하다.
[System.Serializable]
public class JobListWrapper
{
    public int slot;
    public List<Job> jobs;
}

[System.Serializable]
public class Slot
{
    public int recentSlot;

    public Slot(int slot)
    {
        recentSlot = slot;
    }
}
