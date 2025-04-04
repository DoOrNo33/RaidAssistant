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

    public void AddToRoster(Enums.Class cl, Enums.Roll role, Enums.Range range, Enums.Armor armor,
        Enums.Warrior warriorTalent = Enums.Warrior.Null,
        Enums.Paladin paladinTalent = Enums.Paladin.Null,
        Enums.DeathKnight deathKnightTalent = Enums.DeathKnight.Null,
        Enums.Evoker evokerTalent = Enums.Evoker.Null,
        Enums.Shaman shamanTalent = Enums.Shaman.Null,
        Enums.Hunter hunterTalent = Enums.Hunter.Null,
        Enums.DemonHunter demonHunterTalent = Enums.DemonHunter.Null,
        Enums.Druid druidTalent = Enums.Druid.Null,
        Enums.Rogue rogueTalent = Enums.Rogue.Null,
        Enums.Monk monkTalent = Enums.Monk.Null,
        Enums.Priest priestTalent = Enums.Priest.Null,
        Enums.Warlock warlockTalent = Enums.Warlock.Null,
        Enums.Mage mageTalent = Enums.Mage.Null)
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

        // 클래스 오브젝트 세팅을 위한 컴포넌트 가져오기
        ClassObjectSetup classBtnSetup = pObj.GetComponent<ClassObjectSetup>();

        // 버튼 이름 변경
        pObj.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = cl.ToString();
    }
}
