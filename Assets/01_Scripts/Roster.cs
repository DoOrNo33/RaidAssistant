using UnityEngine;
using System.Collections.Generic;
using TMPro;
using static Enums;
using Unity.VisualScripting;

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

    public void AddToRoster(Enums.Class cl, Enums.Roll role, Enums.Range range, Enums.Armor armor, Enums.ClassTalent cT, bool isLoading = false, string name = null )
    {
        Job job = new Job();
        job.jobClass = cl;
        job.role = role;
        job.range = range;
        job.armor = armor;
        job.classTalent = cT;


        // 이름이 정해져 있으면 이름을 설정
        if (name != null)
        {
            job.name = name;
        }

        //// 로스터에 추가
        //if (!isLoading)
        //{
        roster.Add(job);
        //}

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

        // 티어 UI를 업데이트 하기 위한 정보
        UpdateTier(cl, true);

        // 방어구 UI를 업데이트 하기 위한 정보
        UpdateArmor(armor, true);

        // 클래스 오브젝트 세팅을 위한 컴포넌트 가져오기
        ClassObjectSetup classObjectSetup = pObj.GetComponent<ClassObjectSetup>();

        // 클래스 오브젝트 세팅
        classObjectSetup.SetupClassObject(cT);
        classObjectSetup.SetupObjectJob(job);

        if (name != null)
        {
            classObjectSetup.SetupPlayerName(job.name);
        }

        // 세이브
        if (!isLoading)
        {
            dataManager.OnSaveData(roster);
        }
    }

    public void DeleteRoster(Job jb, bool reset = false)
    {
        //roster.Remove(jb);
        if (roster.Contains(jb))
        {
            roster.Remove(jb);
            Debug.Log("Job 객체가 동일하여 삭제되었습니다.");

            // Contains
            //1.	roster: List<Job> 타입의 리스트입니다. roster는 Job 객체를 저장하는 리스트입니다.
            //            2.jb: Job 타입의 객체로, 리스트에 포함되어 있는지 확인하려는 대상입니다.
            //3.Contains 메서드: 리스트의 각 요소와 jb를 비교하여 동일한 객체가 있는지 확인합니다.
             //동일성 비교 기준
           //roster.Contains(jb)는 다음 기준으로 jb와 리스트의 요소를 비교합니다:
            //            1.참조 비교: Job 클래스에서 Equals 메서드를 재정의하지 않았다면, 기본적으로 참조 비교를 수행합니다.즉, jb와 리스트의 요소가 동일한 메모리 주소를 가리키는지 확인합니다.
              //2.Equals 메서드 재정의: Job 클래스에서 Equals 메서드를 재정의한 경우, 재정의된 로직에 따라 동일성을 비교합니다. 예를 들어, Job의 속성 값이 동일한지 확인하도록 구현할 수 있습니다.
        }
        else
        {
            Debug.LogError("Roster에 존재하지 않는 Job입니다.");
            return;
        }

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

        // 티어 UI를 업데이트 하기 위한 정보
        UpdateTier(jb.jobClass, false);

        // 방어구 UI를 업데이트 하기 위한 정보
        UpdateArmor(jb.armor, false);

        // 오브젝트 삭제
        Destroy(jb.AssociatedObject);

        // 클래스 객체 삭제
        // 가비지 컬렉터를 통해 참조되지 않는 객체는 자동 삭제

        // 리셋이 아닐 경우 저장
        if (!reset)
        {
            dataManager.OnSaveData(roster);
        }
    }

    //public void LoadRoster(List<Job> data)
    //{
    //    roster = data;
    //}

    private void UpdateTier(Enums.Class cl, bool plusMinus)
    {
        switch (cl)
        {
            case Enums.Class.Warrior:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.WRMECount++;
                else
                    GameManager.Instance.TierCountEventHandler.WRMECount--;
                break;
            case Enums.Class.Paladin:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.PPSCount++;
                else
                    GameManager.Instance.TierCountEventHandler.PPSCount--;
                break;
            case Enums.Class.DeathKnight:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.DWDCount++;
                else
                    GameManager.Instance.TierCountEventHandler.DWDCount--;
                break;
            case Enums.Class.Evoker:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.WRMECount++;
                else
                    GameManager.Instance.TierCountEventHandler.WRMECount--;
                break;
            case Enums.Class.Shaman:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.PPSCount++;
                else
                    GameManager.Instance.TierCountEventHandler.PPSCount--;
                break;
            case Enums.Class.Hunter:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.HMDCount++;
                else
                    GameManager.Instance.TierCountEventHandler.HMDCount--;
                break;
            case Enums.Class.DemonHunter:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.DWDCount++;
                else
                    GameManager.Instance.TierCountEventHandler.DWDCount--;
                break;
            case Enums.Class.Druid:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.HMDCount++;
                else
                    GameManager.Instance.TierCountEventHandler.HMDCount--;
                break;
            case Enums.Class.Rogue:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.WRMECount++;
                else
                    GameManager.Instance.TierCountEventHandler.WRMECount--;
                break;
            case Enums.Class.Monk:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.WRMECount++;
                else
                    GameManager.Instance.TierCountEventHandler.WRMECount--;
                break;
            case Enums.Class.Priest:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.PPSCount++;
                else
                    GameManager.Instance.TierCountEventHandler.PPSCount--;
                break;
            case Enums.Class.Warlock:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.DWDCount++;
                else
                    GameManager.Instance.TierCountEventHandler.DWDCount--;
                break;
            case Enums.Class.Mage:
                if (plusMinus)
                    GameManager.Instance.TierCountEventHandler.HMDCount++;
                else
                    GameManager.Instance.TierCountEventHandler.HMDCount--;
                break;
            default:
                Debug.LogError("클래스 타입 미정");
                break;
        }
    }

    private void UpdateArmor(Enums.Armor armor, bool plusMinus)
    {
        switch (armor)
        {
            case Enums.Armor.Plate:
                if (plusMinus)
                    GameManager.Instance.ArmourCountEventHandler.PlateCount++;
                else
                    GameManager.Instance.ArmourCountEventHandler.PlateCount--;
                break;
            case Enums.Armor.Mail:
                if (plusMinus)
                    GameManager.Instance.ArmourCountEventHandler.MailCount++;
                else
                    GameManager.Instance.ArmourCountEventHandler.MailCount--;
                break;
            case Enums.Armor.Leather:
                if (plusMinus)
                    GameManager.Instance.ArmourCountEventHandler.LeatherCount++;
                else
                    GameManager.Instance.ArmourCountEventHandler.LeatherCount--;
                break;
            case Enums.Armor.Cloth:
                if (plusMinus)
                    GameManager.Instance.ArmourCountEventHandler.ClothCount++;
                else
                    GameManager.Instance.ArmourCountEventHandler.ClothCount--;
                break;
            default:
                Debug.LogError("방어구 타입 미정");
                break;
        }
    }

    // 로스터 리셋
    public void ResetRoster()
    {
        List<Job> copyRoster = new List<Job>(roster);

        foreach (Job jb in copyRoster)
        {
            DeleteRoster(jb, reset: true); // reset 플래그를 true로 설정
        }
        
        // 로스터 UI정보등이 초기화 안 되서 이 방식은 아닌듯
    }
}
