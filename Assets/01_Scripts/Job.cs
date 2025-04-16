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
}

// List<Job>를 감싸는 클래스를 추가
// JsonUtility는 제네릭 타입을 지원하지 않으므로, 데이터를 감싸는 클래스가 필요하다.
[System.Serializable]
public class JobListWrapper
{
    public List<Job> jobs;
}
