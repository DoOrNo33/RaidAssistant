using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class BuffUIController : MonoBehaviour
{
    [SerializeField] private List<RawImage> buffIcons;
    [SerializeField] private float offAlpha = 100f;
    private float onAlpha = 255f;
    private float _offAlpha;
    private float _onAlpha;

        private Color bloodlustColor;
        private Color battleShoutColor;
        private Color powerWordFortitudeColor;
        private Color arcaneIntellectColor ;
        private Color skyfuryColor;
        private Color markoftheWildColor;
        private Color blessingoftheBronzeColor;
        private Color mysticTouchColor;
        private Color chaosBrandColor;
        private Color huntersMarkColor;
        private Color poisonColor;
        private Color devotionAuraColor;
        private Color healthstoneColor;
        private Color deathGripColor;

    private void Awake()
    {
        // 버프 아이콘 초기 세팅
        Initialize();
    }

    // 이벤트 구독/해제
    private void OnEnable() 
    {
        BuffEventHandler.Instance.SetBloodlustEvent(UpdateBloodlustIcon);    
        BuffEventHandler.Instance.SetBattleShoutEvent(UpdateBattleShoutIcon);
        BuffEventHandler.Instance.SetPowerWordFortitudeEvent(UpdatePowerWordFortitudeIcon);
        BuffEventHandler.Instance.SetArcaneIntellectEvent(UpdateArcaneIntellectIcon);
        BuffEventHandler.Instance.SetSkyfuryEvent(UpdateSkyfuryIcon);
        BuffEventHandler.Instance.SetMarkoftheWildEvent(UpdateMarkoftheWildIcon);
        BuffEventHandler.Instance.SetBlessingoftheBronzeEvent(UpdateBlessingoftheBronzeIcon);
        BuffEventHandler.Instance.SetMysticTouchEvent(UpdateMysticTouchIcon);
        BuffEventHandler.Instance.SetChaosBrandEvent(UpdateChaosBrandIcon);
        BuffEventHandler.Instance.SetHuntersMarkEvent(UpdateHuntersMarkIcon);
        BuffEventHandler.Instance.SetPoisonEvent(UpdatePoisonIcon);
        BuffEventHandler.Instance.SetDevotionAuraEvent(UpdateDevotionAuraIcon);
        BuffEventHandler.Instance.SetHealthstoneEvent(UpdateHealthstoneIcon);
        BuffEventHandler.Instance.SetDeathGripEvent(UpdateDeathGripIcon);
    }

    private void OnDisable() 
    {
        BuffEventHandler.Instance.RemoveBloodlustEvent(UpdateBloodlustIcon);
        BuffEventHandler.Instance.RemoveBattleShoutEvent(UpdateBattleShoutIcon);
        BuffEventHandler.Instance.RemovePowerWordFortitudeEvent(UpdatePowerWordFortitudeIcon);
        BuffEventHandler.Instance.RemoveArcaneIntellectEvent(UpdateArcaneIntellectIcon);
        BuffEventHandler.Instance.RemoveSkyfuryEvent(UpdateSkyfuryIcon);
        BuffEventHandler.Instance.RemoveMarkoftheWildEvent(UpdateMarkoftheWildIcon);
        BuffEventHandler.Instance.RemoveBlessingoftheBronzeEvent(UpdateBlessingoftheBronzeIcon);
        BuffEventHandler.Instance.RemoveMysticTouchEvent(UpdateMysticTouchIcon);
        BuffEventHandler.Instance.RemoveChaosBrandEvent(UpdateChaosBrandIcon);
        BuffEventHandler.Instance.RemoveHuntersMarkEvent(UpdateHuntersMarkIcon);
        BuffEventHandler.Instance.RemovePoisonEvent(UpdatePoisonIcon);
        BuffEventHandler.Instance.RemoveDevotionAuraEvent(UpdateDevotionAuraIcon);
        BuffEventHandler.Instance.RemoveHealthstoneEvent(UpdateHealthstoneIcon);
        BuffEventHandler.Instance.RemoveDeathGripEvent(UpdateDeathGripIcon);
    }

    public void Initialize()
    {
        // 색상 정의 초기화
        bloodlustColor = ClassColorDefine.BloodlustColor;
        battleShoutColor = ClassColorDefine.WarriorColor;
        powerWordFortitudeColor = ClassColorDefine.PriestColor;
        arcaneIntellectColor = ClassColorDefine.MageColor;
        skyfuryColor = ClassColorDefine.ShamanColor;
        markoftheWildColor = ClassColorDefine.DruidColor;
        blessingoftheBronzeColor = ClassColorDefine.EvokerColor;
        mysticTouchColor = ClassColorDefine.MonkColor;
        chaosBrandColor = ClassColorDefine.DemonHunterColor;
        huntersMarkColor = ClassColorDefine.HunterColor;
        poisonColor = ClassColorDefine.RogueColor;
        devotionAuraColor = ClassColorDefine.PaladinColor;
        healthstoneColor = ClassColorDefine.WarlockColor;
        deathGripColor = ClassColorDefine.DeathKnightColor;

        // 투명도 설정
        _offAlpha = offAlpha / onAlpha;
        _onAlpha = onAlpha / onAlpha;

        bloodlustColor.a = _offAlpha;
        battleShoutColor.a = _offAlpha;
        powerWordFortitudeColor.a = _offAlpha;
        arcaneIntellectColor.a = _offAlpha;
        skyfuryColor.a = _offAlpha;
        markoftheWildColor.a = _offAlpha;
        blessingoftheBronzeColor.a = _offAlpha;
        mysticTouchColor.a = _offAlpha;
        chaosBrandColor.a = _offAlpha;
        huntersMarkColor.a = _offAlpha;
        poisonColor.a = _offAlpha;
        devotionAuraColor.a = _offAlpha;
        healthstoneColor.a = _offAlpha;
        deathGripColor.a = _offAlpha;

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

    private void UpdateBloodlustIcon(bool value)
    {
        if (value)
        {
            bloodlustColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.Bloodlust].color = bloodlustColor;
        }
        else
        {
            bloodlustColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.Bloodlust].color = bloodlustColor;
        }
    }

    private void UpdateBattleShoutIcon(bool value)
    {
        if (value)
        {
            battleShoutColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.BattleShout].color = battleShoutColor;
        }
        else
        {
            battleShoutColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.BattleShout].color = battleShoutColor;
        }
    }

    private void UpdatePowerWordFortitudeIcon(bool value)
    {
        if (value)
        {
            powerWordFortitudeColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.PowerWordFortitude].color = powerWordFortitudeColor;
        }
        else
        {
            powerWordFortitudeColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.PowerWordFortitude].color = powerWordFortitudeColor;
        }
    }

    private void UpdateArcaneIntellectIcon(bool value)
    {
        if (value)
        {
            arcaneIntellectColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.ArcaneIntellect].color = arcaneIntellectColor;
        }
        else
        {
            arcaneIntellectColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.ArcaneIntellect].color = arcaneIntellectColor;
        }
    }

    private void UpdateSkyfuryIcon(bool value)
    {
        if (value)
        {
            skyfuryColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.Skyfury].color = skyfuryColor;
        }
        else
        {
            skyfuryColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.Skyfury].color = skyfuryColor;
        }
    }

    private void UpdateMarkoftheWildIcon(bool value)
    {
        if (value)
        {
            markoftheWildColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.MarkoftheWild].color = markoftheWildColor;
        }
        else
        {
            markoftheWildColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.MarkoftheWild].color = markoftheWildColor;
        }
    }

    private void UpdateBlessingoftheBronzeIcon(bool value)
    {
        if (value)
        {
            blessingoftheBronzeColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.BlessingoftheBronze].color = blessingoftheBronzeColor;
        }
        else
        {
            blessingoftheBronzeColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.BlessingoftheBronze].color = blessingoftheBronzeColor;
        }
    }

    private void UpdateMysticTouchIcon(bool value)
    {
        if (value)
        {
            mysticTouchColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.MysticTouch].color = mysticTouchColor;
        }
        else
        {
            mysticTouchColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.MysticTouch].color = mysticTouchColor;
        }
    }

    private void UpdateChaosBrandIcon(bool value)
    {
        if (value)
        {
            chaosBrandColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.ChaosBrand].color = chaosBrandColor;
        }
        else
        {
            chaosBrandColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.ChaosBrand].color = chaosBrandColor;
        }
    }

    private void UpdateHuntersMarkIcon(bool value)
    {
        if (value)
        {
            huntersMarkColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.HuntersMark].color = huntersMarkColor;
        }
        else
        {
            huntersMarkColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.HuntersMark].color = huntersMarkColor;
        }
    }

    private void UpdatePoisonIcon(bool value)
    {
        if (value)
        {
            poisonColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.Poison].color = poisonColor;
        }
        else
        {
            poisonColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.Poison].color = poisonColor;
        }
    }

    private void UpdateDevotionAuraIcon(bool value)
    {
        if (value)
        {
            devotionAuraColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.DevotionAura].color = devotionAuraColor;
        }
        else
        {
            devotionAuraColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.DevotionAura].color = devotionAuraColor;
        }
    }

    private void UpdateHealthstoneIcon(bool value)
    {
        if (value)
        {
            healthstoneColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.Healthstone].color = healthstoneColor;
        }
        else
        {
            healthstoneColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.Healthstone].color = healthstoneColor;
        }
    }

    private void UpdateDeathGripIcon(bool value)
    {
        if (value)
        {
            deathGripColor.a = _onAlpha;
            buffIcons[(int)Enums.RaidSynergy.DeathGrip].color = deathGripColor;
        }
        else
        {
            deathGripColor.a = _offAlpha;
            buffIcons[(int)Enums.RaidSynergy.DeathGrip].color = deathGripColor;
        }
    }
}
