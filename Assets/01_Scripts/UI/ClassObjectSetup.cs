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
}
