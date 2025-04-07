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

    [Header("클래스 로스터")]
    [SerializeField] private ClassSorter tankSorter;
    [SerializeField] private ClassSorter meleeSorter;
    [SerializeField] private ClassSorter rangedSorter;
    [SerializeField] private ClassSorter healerSorter;

#region OldAddToRoster
    // public void AddToRoster(Enums.Class cl, Enums.Roll role, Enums.Range range, Enums.Armor armor,
    //     Enums.Warrior warriorTalent = Enums.Warrior.Null,
    //     Enums.Paladin paladinTalent = Enums.Paladin.Null,
    //     Enums.DeathKnight deathKnightTalent = Enums.DeathKnight.Null,
    //     Enums.Evoker evokerTalent = Enums.Evoker.Null,
    //     Enums.Shaman shamanTalent = Enums.Shaman.Null,
    //     Enums.Hunter hunterTalent = Enums.Hunter.Null,
    //     Enums.DemonHunter demonHunterTalent = Enums.DemonHunter.Null,
    //     Enums.Druid druidTalent = Enums.Druid.Null,
    //     Enums.Rogue rogueTalent = Enums.Rogue.Null,
    //     Enums.Monk monkTalent = Enums.Monk.Null,
    //     Enums.Priest priestTalent = Enums.Priest.Null,
    //     Enums.Warlock warlockTalent = Enums.Warlock.Null,
    //     Enums.Mage mageTalent = Enums.Mage.Null)
    // {
    //     Job job = new Job();
    //     job.jobClass = cl;
    //     job.role = role;
    //     job.range = range;
    //     job.armor = armor;

    //     roster.Add(job);

    //     // 생성할 오브젝트 초기화
    //     GameObject pObj = null;

    //     switch (role)
    //     {
    //         case Enums.Roll.Tank:
    //             pObj = Instantiate(playerObj, tankRoster.transform);
    //             break;
    //         case Enums.Roll.DPS:
    //             if (range == Enums.Range.Melee)
    //             {
    //                 pObj = Instantiate(playerObj, meleeRoster.transform);
    //             }
    //             else
    //             {
    //                 pObj = Instantiate(playerObj, rangedRoster.transform);
    //             }
    //             break;
    //         case Enums.Roll.Healer:
    //             pObj = Instantiate(playerObj, healerRoster.transform);
    //             break;
    //     }

    //     // 클래스 오브젝트 세팅을 위한 컴포넌트 가져오기
    //     ClassObjectSetup classObjectSetup = pObj.GetComponent<ClassObjectSetup>();

    //     // 클래스 오브젝트 세팅
    //     switch (cl)
    //     {
    //         case Enums.Class.Warrior:
    //             classObjectSetup.SetupWarriorObject(warriorTalent);
    //             break;
    //         case Enums.Class.Paladin:
    //             classObjectSetup.SetupPaladinObject(paladinTalent);
    //             break;
    //         case Enums.Class.DeathKnight:
    //             classObjectSetup.SetupDeathKnightObject(deathKnightTalent);
    //             break;
    //         case Enums.Class.Evoker:
    //             classObjectSetup.SetupEvokerObject(evokerTalent);
    //             break;
    //         case Enums.Class.Shaman:
    //             classObjectSetup.SetupShamanObject(shamanTalent);
    //             break;
    //         case Enums.Class.Hunter:
    //             classObjectSetup.SetupHunterObject(hunterTalent);
    //             break;
    //         case Enums.Class.DemonHunter:
    //             classObjectSetup.SetupDemonHunterObject(demonHunterTalent);
    //             break;
    //         case Enums.Class.Druid:
    //             classObjectSetup.SetupDruidObject(druidTalent);
    //             break;
    //         case Enums.Class.Rogue:
    //             classObjectSetup.SetupRogueObject(rogueTalent);
    //             break;
    //         case Enums.Class.Monk:
    //             classObjectSetup.SetupMonkObject(monkTalent);
    //             break;
    //         case Enums.Class.Priest:
    //             classObjectSetup.SetupPriestObject(priestTalent);
    //             break;
    //         case Enums.Class.Warlock:
    //             classObjectSetup.SetupWarlockObject(warlockTalent);
    //             break;
    //         case Enums.Class.Mage:
    //             classObjectSetup.SetupMageObject(mageTalent);
    //             break;
    //         default:
    //             Debug.LogError("클래스 타입 미정");
    //             break;
    //     }
    // }
#endregion

    public void AddToRoster(Enums.Class cl, Enums.Roll role, Enums.Range range, Enums.Armor armor, Enums.ClassTalent cT)
    {
        Job job = new Job();
        job.jobClass = cl;
        job.role = role;
        job.range = range;
        job.armor = armor;
        job.classTalent = cT;

        roster.Add(job);

        // 생성할 오브젝트 초기화
        GameObject pObj = null;
        
        // 오브젝트 생성
        pObj = Instantiate(playerObj);

        // Job에 오브젝트 연결
        job.AssociatedObject = pObj;

        switch (role)
        {
            case Enums.Roll.Tank:
                pObj.transform.SetParent(tankRoster.transform);
                tankSorter.AddToRoster(job);
                break;
            case Enums.Roll.DPS:
                if (range == Enums.Range.Melee)
                {
                    pObj.transform.SetParent(meleeRoster.transform);
                    meleeSorter.AddToRoster(job);
                }
                else
                {
                    pObj.transform.SetParent(rangedRoster.transform);
                    rangedSorter.AddToRoster(job);
                }
                break;
            case Enums.Roll.Healer:
                pObj.transform.SetParent(healerRoster.transform);
                healerSorter.AddToRoster(job);
                break;
        }

        // 클래스 오브젝트 세팅을 위한 컴포넌트 가져오기
        ClassObjectSetup classObjectSetup = pObj.GetComponent<ClassObjectSetup>();

        // 클래스 오브젝트 세팅
        classObjectSetup.SetupClassObject(cT);
        classObjectSetup.SetupObjectJob(job);
    }
}
