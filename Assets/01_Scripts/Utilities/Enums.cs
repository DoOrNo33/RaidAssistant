using UnityEngine;

public class Enums
{
    public enum Class
    {
        Warrior,
        Paladin,
        DeathKnight,
        Evoker,
        Shaman,
        Hunter,
        DemonHunter,
        Druid,
        Rogue,
        Monk,
        Priest,
        Warlock,
        Mage,
    }

    public enum Roll
    {
        Tank,
        Healer,
        DPS,
    }

    public enum Range
    {
        Melee,
        Ranged,
    }

    public enum Armor
    {
        Cloth,
        Leather,
        Mail,
        Plate,
    }

    public enum Warrior
    {
        Null,
        Arms,
        Fury,
        Protection,
    }

    public enum Paladin
    {
        Null,
        Holy,
        Protection,
        Retribution,
    }

    public enum DeathKnight
    {
        Null,
        Blood,
        Frost,
        Unholy,
    }

    public enum Evoker
    {
        Null,
        Devastation,
        Augmentation,
        Preservation,
    }

    public enum Shaman
    {
        Null,
        Elemental,
        Enhancement,
        Restoration,
    }

    public enum Hunter
    {
        Null,
        BeastMastery,
        Marksmanship,
        Survival,
    }

    public enum DemonHunter
    {
        Null,
        Havoc,
        Vengeance,
    }

    public enum Druid
    {
        Null,
        Balance,
        Feral,
        Guardian,
        Restoration,
    }

    public enum Rogue
    {
        Null,
        Assassination,
        Outlaw,
        Subtlety,
    }

    public enum Monk
    {
        Null,
        Brewmaster,
        Mistweaver,
        Windwalker,
    }

    public enum Priest
    {
        Null,
        Discipline,
        Holy,
        Shadow,
    }

    public enum Warlock
    {
        Null,
        Affliction,
        Demonology,
        Destruction,
    }

    public enum Mage
    {
        Null,
        Arcane,
        Fire,
        Frost,
    }

        public enum ClassTalent
    {
        WarriorProtection = 1011,
        WarriorFury,
        WarriorArms,
        PaladinProtection = 1021,
        PaladinRetribution,
        PaladinHoly,
        DeathKnightBlood = 1031,
        DeathKnightFrost,
        DeathKnightUnholy,
        EvokerDevastation = 1041,
        EvokerAugmentation,
        EvokerPreservation,
        ShamanEnhancement = 1051,
        ShamanElemental,
        ShamanRestoration,
        HunterSurvival = 1061,
        HunterBeastMastery,
        HunterMarksmanship,
        DemonHunterVengeance = 1071,
        DemonHunterHavoc,
        DruidGuardian = 1081,
        DruidFeral,
        DruidBalance,
        DruidRestoration,
        RogueAssassination = 1091,
        RogueOutlaw,
        RogueSubtlety,
        MonkBrewmaster = 1101,
        MonkWindwalker,
        MonkMistweaver,
        PriestShadow = 1111,
        PriestHoly,
        PriestDiscipline,
        WarlockAffliction = 1121,
        WarlockDemonology,
        WarlockDestruction,
        MageArcane = 1131,
        MageFire,
        MageFrost,
    }
}
