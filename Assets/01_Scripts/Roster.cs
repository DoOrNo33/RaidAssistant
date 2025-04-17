using UnityEngine;
using System.Collections.Generic;
using TMPro;

public class Roster : Singleton<Roster>
{
    [SerializeField] private List<Job> roster;
    [SerializeField] private DataManager dataManager;

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

    // 세이브 테스트 용
    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            dataManager.OnSaveData(roster);
        }
    }

    public void AddToRoster(Enums.Class cl, Enums.Roll role, Enums.Range range, Enums.Armor armor, Enums.ClassTalent cT, bool isLoading = false )
    {
        Job job = new Job();
        job.jobClass = cl;
        job.role = role;
        job.range = range;
        job.armor = armor;
        job.classTalent = cT;

        // 로스터에 추가
        if (!isLoading)
        {
            roster.Add(job);
        }

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

                MemberCountEventHandler.Instance.TankCount++;                       // Tank 수 증가
                break;
            case Enums.Roll.DPS:
                if (range == Enums.Range.Melee)
                {
                    pObj.transform.SetParent(meleeRoster.transform);
                    meleeSorter.AddToRoster(job);

                    MemberCountEventHandler.Instance.MeleeCount++;                  // Melee 수 증가
                }
                else
                {
                    pObj.transform.SetParent(rangedRoster.transform);
                    rangedSorter.AddToRoster(job);

                    MemberCountEventHandler.Instance.RangedCount++;                 // Ranged 수 증가
                }
                break;
            case Enums.Roll.Healer:
                pObj.transform.SetParent(healerRoster.transform);
                healerSorter.AddToRoster(job);

                MemberCountEventHandler.Instance.HealerCount++;                     // Healer 수 증가
                break;
        }

        // 버프 UI 세팅
        switch (cl)
        {
            case Enums.Class.Warrior:
                BuffEventHandler.Instance.IsBattleShout++;
                break;
            case Enums.Class.Paladin:
                BuffEventHandler.Instance.IsDevotionAura++;
                break;
            case Enums.Class.DeathKnight:
                BuffEventHandler.Instance.IsDeathGrip++;
                break;
            case Enums.Class.Evoker:
                BuffEventHandler.Instance.IsBlessingoftheBronze++;
                BuffEventHandler.Instance.IsBloodlust++;
                break;
            case Enums.Class.Shaman:
                BuffEventHandler.Instance.IsSkyfury++;
                BuffEventHandler.Instance.IsBloodlust++;
                break;
            case Enums.Class.Hunter:
                BuffEventHandler.Instance.IsHuntersMark++;
                BuffEventHandler.Instance.IsBloodlust++;
                break;
            case Enums.Class.DemonHunter:
                BuffEventHandler.Instance.IsChaosBrand++;
                break;
            case Enums.Class.Druid:
                BuffEventHandler.Instance.IsMarkoftheWild++;
                break;
            case Enums.Class.Rogue:
                BuffEventHandler.Instance.IsPoison++;
                break;
            case Enums.Class.Monk:
                BuffEventHandler.Instance.IsMysticTouch++;
                break;
            case Enums.Class.Priest:
                BuffEventHandler.Instance.IsPowerWordFortitude++;
                break;
            case Enums.Class.Warlock:
                BuffEventHandler.Instance.IsHealthstone++;
                break;
            case Enums.Class.Mage:
                BuffEventHandler.Instance.IsArcaneIntellect++;
                BuffEventHandler.Instance.IsBloodlust++;
                break;
        }

        // 클래스 오브젝트 세팅을 위한 컴포넌트 가져오기
        ClassObjectSetup classObjectSetup = pObj.GetComponent<ClassObjectSetup>();

        // 클래스 오브젝트 세팅
        classObjectSetup.SetupClassObject(cT);
        classObjectSetup.SetupObjectJob(job);

        // 세이브
        if (!isLoading)
        {
        dataManager.OnSaveData(roster);
        }
    }

    public void DeleteRoster(Job jb)
    {
        roster.Remove(jb);

        switch (jb.role)
        {
            case Enums.Roll.Tank:
                tankSorter.DeleteRoster(jb);

                MemberCountEventHandler.Instance.TankCount--;                       // Tank 수 감소
                break;
            case Enums.Roll.DPS:
                if (jb.range == Enums.Range.Melee)
                {
                    meleeSorter.DeleteRoster(jb);

                    MemberCountEventHandler.Instance.MeleeCount--;                  // Melee 수 감소
                }
                else
                {
                    rangedSorter.DeleteRoster(jb);

                    MemberCountEventHandler.Instance.RangedCount--;                 // Ranged 수 감소
                }
                break;
            case Enums.Roll.Healer:
                healerSorter.DeleteRoster(jb);

                MemberCountEventHandler.Instance.HealerCount--;                     // Healer 수 감소
                break;
        }

        switch (jb.jobClass)
        {
            case Enums.Class.Warrior:
                BuffEventHandler.Instance.IsBattleShout--;
                break;
            case Enums.Class.Paladin:
                BuffEventHandler.Instance.IsDevotionAura--;
                break;
            case Enums.Class.DeathKnight:
                BuffEventHandler.Instance.IsDeathGrip--;
                break;
            case Enums.Class.Evoker:
                BuffEventHandler.Instance.IsBlessingoftheBronze--;
                BuffEventHandler.Instance.IsBloodlust--;
                break;
            case Enums.Class.Shaman:
                BuffEventHandler.Instance.IsSkyfury--;
                BuffEventHandler.Instance.IsBloodlust--;
                break;
            case Enums.Class.Hunter:
                BuffEventHandler.Instance.IsHuntersMark--;
                BuffEventHandler.Instance.IsBloodlust--;
                break;
            case Enums.Class.DemonHunter:
                BuffEventHandler.Instance.IsChaosBrand--;
                break;
            case Enums.Class.Druid:
                BuffEventHandler.Instance.IsMarkoftheWild--;
                break;
            case Enums.Class.Rogue:
                BuffEventHandler.Instance.IsPoison--;
                break;
            case Enums.Class.Monk:
                BuffEventHandler.Instance.IsMysticTouch--;
                break;
            case Enums.Class.Priest:
                BuffEventHandler.Instance.IsPowerWordFortitude--;
                break;
            case Enums.Class.Warlock:
                BuffEventHandler.Instance.IsHealthstone--;
                break;
            case Enums.Class.Mage:
                BuffEventHandler.Instance.IsArcaneIntellect--;
                BuffEventHandler.Instance.IsBloodlust--;
                break;
        }

        // 오브젝트 삭제
        Destroy(jb.AssociatedObject);

        // 클래스 객체 삭제
        // 가비지 컬렉터를 통해 참조되지 않는 객체는 자동 삭제

        // 세이브
        dataManager.OnSaveData(roster);
    }

    public void LoadRoster(List<Job> data)
    {
        roster = data;
    }
}
