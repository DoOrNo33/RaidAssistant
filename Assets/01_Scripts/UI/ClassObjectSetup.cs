using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ClassObjectSetup : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI classNameText;
    [SerializeField] private RawImage buttonColor;

    // 오브젝트가 생성될 때 이 스크립트를 가져와서 세팅을 함.
    public void SetupWarriorObject(Enums.Warrior warriorTalent)
    {
        // warriorTalent에 따라 classNameText와 buttonColor를 설정
        switch (warriorTalent)
        {
            case Enums.Warrior.Arms:
                classNameText.text = ClassNameDefine.WarriorArms;
                buttonColor.color = ClassColorDefine.WarriorColor;
                break;
            case Enums.Warrior.Fury:
                classNameText.text = ClassNameDefine.WarriorFury;
                buttonColor.color = ClassColorDefine.WarriorColor;
                break;
            case Enums.Warrior.Protection:
                classNameText.text = ClassNameDefine.WarriorProtection;
                buttonColor.color = ClassColorDefine.WarriorColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupPaladinObject(Enums.Paladin paladinTalent)
    {
        // paladinTalent에 따라 classNameText와 buttonColor를 설정
        switch (paladinTalent)
        {
            case Enums.Paladin.Holy:
                classNameText.text = ClassNameDefine.PaladinHoly;
                buttonColor.color = ClassColorDefine.PaladinColor;
                break;
            case Enums.Paladin.Protection:
                classNameText.text = ClassNameDefine.PaladinProtection;
                buttonColor.color = ClassColorDefine.PaladinColor;
                break;
            case Enums.Paladin.Retribution:
                classNameText.text = ClassNameDefine.PaladinRetribution;
                buttonColor.color = ClassColorDefine.PaladinColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupDeathKnightObject(Enums.DeathKnight deathKnightTalent)
    {
        // deathKnightTalent에 따라 classNameText와 buttonColor를 설정
        switch (deathKnightTalent)
        {
            case Enums.DeathKnight.Blood:
                classNameText.text = ClassNameDefine.DeathKnightBlood;
                buttonColor.color = ClassColorDefine.DeathKnightColor;
                break;
            case Enums.DeathKnight.Frost:
                classNameText.text = ClassNameDefine.DeathKnightFrost;
                buttonColor.color = ClassColorDefine.DeathKnightColor;
                break;
            case Enums.DeathKnight.Unholy:
                classNameText.text = ClassNameDefine.DeathKnightUnholy;
                buttonColor.color = ClassColorDefine.DeathKnightColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupEvokerObject(Enums.Evoker evokerTalent)
    {
        // evokerTalent에 따라 classNameText와 buttonColor를 설정
        switch (evokerTalent)
        {
            case Enums.Evoker.Devastation:
                classNameText.text = ClassNameDefine.EvokerDevastation;
                buttonColor.color = ClassColorDefine.EvokerColor;
                break;
            case Enums.Evoker.Augmentation:
                classNameText.text = ClassNameDefine.EvokerAugmentation;
                buttonColor.color = ClassColorDefine.EvokerColor;
                break;
            case Enums.Evoker.Preservation:
                classNameText.text = ClassNameDefine.EvokerPreservation;
                buttonColor.color = ClassColorDefine.EvokerColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupShamanObject(Enums.Shaman shamanTalent)
    {
        // shamanTalent에 따라 classNameText와 buttonColor를 설정
        switch (shamanTalent)
        {
            case Enums.Shaman.Elemental:
                classNameText.text = ClassNameDefine.ShamanElemental;
                buttonColor.color = ClassColorDefine.ShamanColor;
                break;
            case Enums.Shaman.Enhancement:
                classNameText.text = ClassNameDefine.ShamanEnhancement;
                buttonColor.color = ClassColorDefine.ShamanColor;
                break;
            case Enums.Shaman.Restoration:
                classNameText.text = ClassNameDefine.ShamanRestoration;
                buttonColor.color = ClassColorDefine.ShamanColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupHunterObject(Enums.Hunter hunterTalent)
    {
        // hunterTalent에 따라 classNameText와 buttonColor를 설정
        switch (hunterTalent)
        {
            case Enums.Hunter.BeastMastery:
                classNameText.text = ClassNameDefine.HunterBeastMastery;
                buttonColor.color = ClassColorDefine.HunterColor;
                break;
            case Enums.Hunter.Marksmanship:
                classNameText.text = ClassNameDefine.HunterMarksmanship;
                buttonColor.color = ClassColorDefine.HunterColor;
                break;
            case Enums.Hunter.Survival:
                classNameText.text = ClassNameDefine.HunterSurvival;
                buttonColor.color = ClassColorDefine.HunterColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupDemonHunterObject(Enums.DemonHunter demonHunterTalent)
    {
        // demonHunterTalent에 따라 classNameText와 buttonColor를 설정
        switch (demonHunterTalent)
        {
            case Enums.DemonHunter.Havoc:
                classNameText.text = ClassNameDefine.DemonHunterHavoc;
                buttonColor.color = ClassColorDefine.DemonHunterColor;
                break;
            case Enums.DemonHunter.Vengeance:
                classNameText.text = ClassNameDefine.DemonHunterVengeance;
                buttonColor.color = ClassColorDefine.DemonHunterColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupDruidObject(Enums.Druid druidTalent)
    {
        // druidTalent에 따라 classNameText와 buttonColor를 설정
        switch (druidTalent)
        {
            case Enums.Druid.Balance:
                classNameText.text = ClassNameDefine.DruidBalance;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;
            case Enums.Druid.Feral:
                classNameText.text = ClassNameDefine.DruidFeral;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;
            case Enums.Druid.Guardian:
                classNameText.text = ClassNameDefine.DruidGuardian;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;
            case Enums.Druid.Restoration:
                classNameText.text = ClassNameDefine.DruidRestoration;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupRogueObject(Enums.Rogue rogueTalent)
    {
        // rogueTalent에 따라 classNameText와 buttonColor를 설정
        switch (rogueTalent)
        {
            case Enums.Rogue.Assassination:
                classNameText.text = ClassNameDefine.RogueAssassination;
                buttonColor.color = ClassColorDefine.RogueColor;
                break;
            case Enums.Rogue.Outlaw:
                classNameText.text = ClassNameDefine.RogueOutlaw;
                buttonColor.color = ClassColorDefine.RogueColor;
                break;
            case Enums.Rogue.Subtlety:
                classNameText.text = ClassNameDefine.RogueSubtlety;
                buttonColor.color = ClassColorDefine.RogueColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupMonkObject(Enums.Monk monkTalent)
    {
        // monkTalent에 따라 classNameText와 buttonColor를 설정
        switch (monkTalent)
        {
            case Enums.Monk.Brewmaster:
                classNameText.text = ClassNameDefine.MonkBrewmaster;
                buttonColor.color = ClassColorDefine.MonkColor;
                break;
            case Enums.Monk.Windwalker:
                classNameText.text = ClassNameDefine.MonkWindwalker;
                buttonColor.color = ClassColorDefine.MonkColor;
                break;
            case Enums.Monk.Mistweaver:
                classNameText.text = ClassNameDefine.MonkMistweaver;
                buttonColor.color = ClassColorDefine.MonkColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupPriestObject(Enums.Priest priestTalent)
    {
        // priestTalent에 따라 classNameText와 buttonColor를 설정
        switch (priestTalent)
        {
            case Enums.Priest.Discipline:
                classNameText.text = ClassNameDefine.PriestDiscipline;
                buttonColor.color = ClassColorDefine.PriestColor;
                break;
            case Enums.Priest.Holy:
                classNameText.text = ClassNameDefine.PriestHoly;
                buttonColor.color = ClassColorDefine.PriestColor;
                break;
            case Enums.Priest.Shadow:
                classNameText.text = ClassNameDefine.PriestShadow;
                buttonColor.color = ClassColorDefine.PriestColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupWarlockObject(Enums.Warlock warlockTalent)
    {
        // warlockTalent에 따라 classNameText와 buttonColor를 설정
        switch (warlockTalent)
        {
            case Enums.Warlock.Affliction:
                classNameText.text = ClassNameDefine.WarlockAffliction;
                buttonColor.color = ClassColorDefine.WarlockColor;
                break;
            case Enums.Warlock.Demonology:
                classNameText.text = ClassNameDefine.WarlockDemonology;
                buttonColor.color = ClassColorDefine.WarlockColor;
                break;
            case Enums.Warlock.Destruction:
                classNameText.text = ClassNameDefine.WarlockDestruction;
                buttonColor.color = ClassColorDefine.WarlockColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupMageObject(Enums.Mage mageTalent)
    {
        // mageTalent에 따라 classNameText와 buttonColor를 설정
        switch (mageTalent)
        {
            case Enums.Mage.Arcane:
                classNameText.text = ClassNameDefine.MageArcane;
                buttonColor.color = ClassColorDefine.MageColor;
                break;
            case Enums.Mage.Fire:
                classNameText.text = ClassNameDefine.MageFire;
                buttonColor.color = ClassColorDefine.MageColor;
                break;
            case Enums.Mage.Frost:
                classNameText.text = ClassNameDefine.MageFrost;
                buttonColor.color = ClassColorDefine.MageColor;
                break;
            default:
                Debug.Log("특성 미설정");
                break;
        }
    }

    public void SetupClassObject(Enums.ClassTalent cT)
    {
        // cT에 따라 classNameText와 buttonColor를 설정
        switch (cT)
        {
            // 전사
            case Enums.ClassTalent.WarriorProtection:
                classNameText.text = ClassNameDefine.WarriorProtection;
                buttonColor.color = ClassColorDefine.WarriorColor;
                break;
            case Enums.ClassTalent.WarriorFury:
                classNameText.text = ClassNameDefine.WarriorFury;
                buttonColor.color = ClassColorDefine.WarriorColor;
                break;
            case Enums.ClassTalent.WarriorArms:
                classNameText.text = ClassNameDefine.WarriorArms;
                buttonColor.color = ClassColorDefine.WarriorColor;
                break;

            // 성기사
            case Enums.ClassTalent.PaladinProtection:
                classNameText.text = ClassNameDefine.PaladinProtection;
                buttonColor.color = ClassColorDefine.PaladinColor;
                break;
            case Enums.ClassTalent.PaladinRetribution:
                classNameText.text = ClassNameDefine.PaladinRetribution;
                buttonColor.color = ClassColorDefine.PaladinColor;
                break;
            case Enums.ClassTalent.PaladinHoly:
                classNameText.text = ClassNameDefine.PaladinHoly;
                buttonColor.color = ClassColorDefine.PaladinColor;
                break;

            // 죽음의 기사
            case Enums.ClassTalent.DeathKnightBlood:
                classNameText.text = ClassNameDefine.DeathKnightBlood;
                buttonColor.color = ClassColorDefine.DeathKnightColor;
                break;
            case Enums.ClassTalent.DeathKnightFrost:
                classNameText.text = ClassNameDefine.DeathKnightFrost;
                buttonColor.color = ClassColorDefine.DeathKnightColor;
                break;
            case Enums.ClassTalent.DeathKnightUnholy:
                classNameText.text = ClassNameDefine.DeathKnightUnholy;
                buttonColor.color = ClassColorDefine.DeathKnightColor;
                break;

            // 기원사
            case Enums.ClassTalent.EvokerDevastation:
                classNameText.text = ClassNameDefine.EvokerDevastation;
                buttonColor.color = ClassColorDefine.EvokerColor;
                break;
            case Enums.ClassTalent.EvokerAugmentation:
                classNameText.text = ClassNameDefine.EvokerAugmentation;
                buttonColor.color = ClassColorDefine.EvokerColor;
                break;
            case Enums.ClassTalent.EvokerPreservation:
                classNameText.text = ClassNameDefine.EvokerPreservation;
                buttonColor.color = ClassColorDefine.EvokerColor;
                break;

            // 주술사
            case Enums.ClassTalent.ShamanEnhancement:
                classNameText.text = ClassNameDefine.ShamanEnhancement;
                buttonColor.color = ClassColorDefine.ShamanColor;
                break;
            case Enums.ClassTalent.ShamanElemental:
                classNameText.text = ClassNameDefine.ShamanElemental;
                buttonColor.color = ClassColorDefine.ShamanColor;
                break;
            case Enums.ClassTalent.ShamanRestoration:
                classNameText.text = ClassNameDefine.ShamanRestoration;
                buttonColor.color = ClassColorDefine.ShamanColor;
                break;

            // 사냥꾼
            case Enums.ClassTalent.HunterSurvival:
                classNameText.text = ClassNameDefine.HunterSurvival;
                buttonColor.color = ClassColorDefine.HunterColor;
                break;
            case Enums.ClassTalent.HunterBeastMastery:
                classNameText.text = ClassNameDefine.HunterBeastMastery;
                buttonColor.color = ClassColorDefine.HunterColor;
                break;
            case Enums.ClassTalent.HunterMarksmanship:
                classNameText.text = ClassNameDefine.HunterMarksmanship;
                buttonColor.color = ClassColorDefine.HunterColor;
                break;

            // 악마사냥꾼
            case Enums.ClassTalent.DemonHunterVengeance:
                classNameText.text = ClassNameDefine.DemonHunterVengeance;
                buttonColor.color = ClassColorDefine.DemonHunterColor;
                break;
            case Enums.ClassTalent.DemonHunterHavoc:
                classNameText.text = ClassNameDefine.DemonHunterHavoc;
                buttonColor.color = ClassColorDefine.DemonHunterColor;
                break;

            // 드루이드
            case Enums.ClassTalent.DruidGuardian:
                classNameText.text = ClassNameDefine.DruidGuardian;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;
            case Enums.ClassTalent.DruidFeral:
                classNameText.text = ClassNameDefine.DruidFeral;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;
            case Enums.ClassTalent.DruidBalance:
                classNameText.text = ClassNameDefine.DruidBalance;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;
            case Enums.ClassTalent.DruidRestoration:
                classNameText.text = ClassNameDefine.DruidRestoration;
                buttonColor.color = ClassColorDefine.DruidColor;
                break;

            // 도적
            case Enums.ClassTalent.RogueAssassination:
                classNameText.text = ClassNameDefine.RogueAssassination;
                buttonColor.color = ClassColorDefine.RogueColor;
                break;
            case Enums.ClassTalent.RogueOutlaw:
                classNameText.text = ClassNameDefine.RogueOutlaw;
                buttonColor.color = ClassColorDefine.RogueColor;
                break;
            case Enums.ClassTalent.RogueSubtlety:
                classNameText.text = ClassNameDefine.RogueSubtlety;
                buttonColor.color = ClassColorDefine.RogueColor;
                break;

            // 수도사
            case Enums.ClassTalent.MonkBrewmaster:
                classNameText.text = ClassNameDefine.MonkBrewmaster;
                buttonColor.color = ClassColorDefine.MonkColor;
                break;
            case Enums.ClassTalent.MonkWindwalker:
                classNameText.text = ClassNameDefine.MonkWindwalker;
                buttonColor.color = ClassColorDefine.MonkColor;
                break;
            case Enums.ClassTalent.MonkMistweaver:
                classNameText.text = ClassNameDefine.MonkMistweaver;
                buttonColor.color = ClassColorDefine.MonkColor;
                break;

            // 사제
            case Enums.ClassTalent.PriestShadow:
                classNameText.text = ClassNameDefine.PriestShadow;
                buttonColor.color = ClassColorDefine.PriestColor;
                break;
            case Enums.ClassTalent.PriestHoly:
                classNameText.text = ClassNameDefine.PriestHoly;
                buttonColor.color = ClassColorDefine.PriestColor;
                break;
            case Enums.ClassTalent.PriestDiscipline:
                classNameText.text = ClassNameDefine.PriestDiscipline;
                buttonColor.color = ClassColorDefine.PriestColor;
                break;

            // 흑마법사
            case Enums.ClassTalent.WarlockAffliction:
                classNameText.text = ClassNameDefine.WarlockAffliction;
                buttonColor.color = ClassColorDefine.WarlockColor;
                break;
            case Enums.ClassTalent.WarlockDemonology:
                classNameText.text = ClassNameDefine.WarlockDemonology;
                buttonColor.color = ClassColorDefine.WarlockColor;
                break;
            case Enums.ClassTalent.WarlockDestruction:
                classNameText.text = ClassNameDefine.WarlockDestruction;
                buttonColor.color = ClassColorDefine.WarlockColor;
                break;

            // 마법사
            case Enums.ClassTalent.MageArcane:
                classNameText.text = ClassNameDefine.MageArcane;
                buttonColor.color = ClassColorDefine.MageColor;
                break;
            case Enums.ClassTalent.MageFire:
                classNameText.text = ClassNameDefine.MageFire;
                buttonColor.color = ClassColorDefine.MageColor;
                break;
            case Enums.ClassTalent.MageFrost:
                classNameText.text = ClassNameDefine.MageFrost;
                buttonColor.color = ClassColorDefine.MageColor;
                break;
                
            // 기본값
            default:
                Debug.Log("특성 미설정");
                break;
        }

    }
}
