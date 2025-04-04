using UnityEngine;

public class AddRosterBtn : MonoBehaviour
{
    [SerializeField] private Enums.Class jobClass; 
    [SerializeField] private Enums.Roll role;
    [SerializeField] private Enums.Range range;
    [SerializeField] private Enums.Armor armor;
    [SerializeField] private Enums.Warrior warriorTalent;
    [SerializeField] private Enums.Paladin paladinTalent;
    [SerializeField] private Enums.DeathKnight deathKnightTalent;
    [SerializeField] private Enums.Evoker evokerTalent;
    [SerializeField] private Enums.Shaman shamanTalent;
    [SerializeField] private Enums.Hunter hunterTalent;
    [SerializeField] private Enums.DemonHunter demonHunterTalent;
    [SerializeField] private Enums.Druid druidTalent;
    [SerializeField] private Enums.Rogue rogueTalent;
    [SerializeField] private Enums.Monk monkTalent;
    [SerializeField] private Enums.Priest priestTalent;
    [SerializeField] private Enums.Warlock warlockTalent;
    [SerializeField] private Enums.Mage mageTalent;
    [SerializeField] private GameObject playerObj;
    [SerializeField] private GameObject meleeRoster;

    public void ClickAddBtn()
    {
        Roster.Instance.AddToRoster(jobClass, role, range, armor,
            warriorTalent,
            paladinTalent,
            deathKnightTalent,
            evokerTalent,
            shamanTalent,
            hunterTalent,
            demonHunterTalent,
            druidTalent,
            rogueTalent,
            monkTalent,
            priestTalent,
            warlockTalent,
            mageTalent);
    }
}
