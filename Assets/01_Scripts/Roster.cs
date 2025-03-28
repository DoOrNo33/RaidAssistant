using UnityEngine;
using System.Collections.Generic;
using TMPro;

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

        // 생성할 오브젝트 초기화
        GameObject pObj = null;

        switch (role)
        {
            case Enums.Roll.Tank:
                pObj = Instantiate(playerObj, tankRoster.transform);
                break;
            case Enums.Roll.DPS:
                if (range == Enums.Range.Melee)
                {
                    pObj = Instantiate(playerObj, meleeRoster.transform);
                }
                else
                {
                    pObj = Instantiate(playerObj, rangedRoster.transform);
                }
                break;
            case Enums.Roll.Healer:
                pObj = Instantiate(playerObj, healerRoster.transform);
                break;
        }

        // 버튼 이름 변경
        pObj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = cl.ToString();
    }
}
