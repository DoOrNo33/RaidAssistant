using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class BuffUIController : MonoBehaviour
{
    [SerializeField] private List<RawImage> buffIcons;
    [SerializeField] private float offAlpha = 100f;

    private void Start()
    {
        // 버프 아이콘 초기 세팅
        Initialize();
    }

    public void Initialize()
    {
        // 색상 정의 초기화
        Color bloodlustColor = ClassColorDefine.BloodlustColor;
        Color battleShoutColor = ClassColorDefine.WarriorColor;
        Color powerWordFortitudeColor = ClassColorDefine.PriestColor;
        Color arcaneIntellectColor = ClassColorDefine.MageColor;
        Color skyfuryColor = ClassColorDefine.ShamanColor;
        Color markoftheWildColor = ClassColorDefine.DruidColor;
        Color blessingoftheBronzeColor = ClassColorDefine.EvokerColor;
        Color mysticTouchColor = ClassColorDefine.MonkColor;
        Color chaosBrandColor = ClassColorDefine.DemonHunterColor;
        Color huntersMarkColor = ClassColorDefine.HunterColor;
        Color poisonColor = ClassColorDefine.RogueColor;
        Color devotionAuraColor = ClassColorDefine.PaladinColor;
        Color healthstoneColor = ClassColorDefine.WarlockColor;
        Color deathGripColor = ClassColorDefine.DeathKnightColor;

        // 투명도 설정
        float alpha = offAlpha / 255f;

        bloodlustColor.a = alpha;
        battleShoutColor.a = alpha;
        powerWordFortitudeColor.a = alpha;
        arcaneIntellectColor.a = alpha;
        skyfuryColor.a = alpha;
        markoftheWildColor.a = alpha;
        blessingoftheBronzeColor.a = alpha;
        mysticTouchColor.a = alpha;
        chaosBrandColor.a = alpha;
        huntersMarkColor.a = alpha;
        poisonColor.a = alpha;
        devotionAuraColor.a = alpha;
        healthstoneColor.a = alpha;
        deathGripColor.a = alpha;

        // 아이콘 색상 설정
        buffIcons[(int)Enums.RaidSynergy.Bloodlust].color = bloodlustColor;
        buffIcons[(int)Enums.RaidSynergy.BattleShout].color = battleShoutColor;
        buffIcons[(int)Enums.RaidSynergy.PowerWordFortitude].color = powerWordFortitudeColor;
        buffIcons[(int)Enums.RaidSynergy.ArcaneIntellect].color = arcaneIntellectColor;
        buffIcons[(int)Enums.RaidSynergy.Skyfury].color = skyfuryColor;
        buffIcons[(int)Enums.RaidSynergy.MarkoftheWild].color = markoftheWildColor;
        buffIcons[(int)Enums.RaidSynergy.BlessingoftheBronze].color = blessingoftheBronzeColor;
        buffIcons[(int)Enums.RaidSynergy.MysticTouch].color = mysticTouchColor;
        buffIcons[(int)Enums.RaidSynergy.ChaosBrand].color = chaosBrandColor;
        buffIcons[(int)Enums.RaidSynergy.HuntersMark].color = huntersMarkColor;
        buffIcons[(int)Enums.RaidSynergy.Poison].color = poisonColor;
        buffIcons[(int)Enums.RaidSynergy.DevotionAura].color = devotionAuraColor;
        buffIcons[(int)Enums.RaidSynergy.Healthstone].color = healthstoneColor;
        buffIcons[(int)Enums.RaidSynergy.DeathGrip].color = deathGripColor;
    }
}
