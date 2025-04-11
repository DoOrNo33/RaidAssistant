using UnityEngine;

public class BuffEventHandler : Singleton<BuffEventHandler>
{
    private int threshold = 1;

    [SerializeField] private int isBloodlust = 0;
    [SerializeField] private int isBattleShout = 0;
    [SerializeField] private int isPowerWordFortitude = 0;
    [SerializeField] private int isArcaneIntellect = 0;
    [SerializeField] private int isSkyfury = 0;
    [SerializeField] private int isMarkoftheWild = 0;
    [SerializeField] private int isBlessingoftheBronze = 0;
    [SerializeField] private int isMysticTouch = 0;
    [SerializeField] private int isChaosBrand = 0;
    [SerializeField] private int isHuntersMark = 0;
    [SerializeField] private int isPoison = 0;
    [SerializeField] private int isDevotionAura = 0;
    [SerializeField] private int isHealthstone = 0;
    [SerializeField] private int isDeathGrip = 0;

    public delegate void UpdateBloodlust(bool value);
    public delegate void UpdateBattleShout(bool value);
    public delegate void UpdatePowerWordFortitude(bool value);
    public delegate void UpdateArcaneIntellect(bool value);
    public delegate void UpdateSkyfury(bool value);
    public delegate void UpdateMarkoftheWild(bool value);
    public delegate void UpdateBlessingoftheBronze(bool value);
    public delegate void UpdateMysticTouch(bool value);
    public delegate void UpdateChaosBrand(bool value);
    public delegate void UpdateHuntersMark(bool value);
    public delegate void UpdatePoison(bool value);
    public delegate void UpdateDevotionAura(bool value);
    public delegate void UpdateHealthstone(bool value);
    public delegate void UpdateDeathGrip(bool value);

    private event UpdateBloodlust updateBloodlust;
    private event UpdateBattleShout updateBattleShout;
    private event UpdatePowerWordFortitude updatePowerWordFortitude;
    private event UpdateArcaneIntellect updateArcaneIntellect;
    private event UpdateSkyfury updateSkyfury;
    private event UpdateMarkoftheWild updateMarkoftheWild;
    private event UpdateBlessingoftheBronze updateBlessingoftheBronze;
    private event UpdateMysticTouch updateMysticTouch;
    private event UpdateChaosBrand updateChaosBrand;
    private event UpdateHuntersMark updateHuntersMark;
    private event UpdatePoison updatePoison;
    private event UpdateDevotionAura updateDevotionAura;
    private event UpdateHealthstone updateHealthstone;
    private event UpdateDeathGrip updateDeathGrip;

    public int IsBloodlust
    {
        get
        {
            return isBloodlust;
        }
        set
        {
            isBloodlust = value;
            updateBloodlust?.Invoke(isBloodlust >= threshold);                      // 블러드 클래스가 1 이상이면 true, 아니면 false
        }
    }

    public int IsBattleShout
    {
        get
        {
            return isBattleShout;
        }
        set
        {
            isBattleShout = value;
            updateBattleShout?.Invoke(isBattleShout >= threshold);
        }
    }

    public int IsPowerWordFortitude
    {
        get
        {
            return isPowerWordFortitude;
        }
        set
        {
            isPowerWordFortitude = value;
            updatePowerWordFortitude?.Invoke(isPowerWordFortitude >= threshold);
        }
    }

    public int IsArcaneIntellect
    {
        get
        {
            return isArcaneIntellect;
        }
        set
        {
            isArcaneIntellect = value;
            updateArcaneIntellect?.Invoke(isArcaneIntellect >= threshold);
        }
    }

    public int IsSkyfury
    {
        get
        {
            return isSkyfury;
        }
        set
        {
            isSkyfury = value;
            updateSkyfury?.Invoke(isSkyfury >= threshold);
        }
    }

    public int IsMarkoftheWild
    {
        get
        {
            return isMarkoftheWild;
        }
        set
        {
            isMarkoftheWild = value;
            updateMarkoftheWild?.Invoke(isMarkoftheWild >= threshold);
        }
    }

    public int IsBlessingoftheBronze
    {
        get
        {
            return isBlessingoftheBronze;
        }
        set
        {
            isBlessingoftheBronze = value;
            updateBlessingoftheBronze?.Invoke(isBlessingoftheBronze >= threshold);
        }
    }

    public int IsMysticTouch
    {
        get
        {
            return isMysticTouch;
        }
        set
        {
            isMysticTouch = value;
            updateMysticTouch?.Invoke(isMysticTouch >= threshold);
        }
    }

    public int IsChaosBrand
    {
        get
        {
            return isChaosBrand;
        }
        set
        {
            isChaosBrand = value;
            updateChaosBrand?.Invoke(isChaosBrand >= threshold);
        }
    }

    public int IsHuntersMark
    {
        get
        {
            return isHuntersMark;
        }
        set
        {
            isHuntersMark = value;
            updateHuntersMark?.Invoke(isHuntersMark >= threshold);
        }
    }

    public int IsPoison
    {
        get
        {
            return isPoison;
        }
        set
        {
            isPoison = value;
            updatePoison?.Invoke(isPoison >= threshold);
        }
    }

    public int IsDevotionAura
    {
        get
        {
            return isDevotionAura;
        }
        set
        {
            isDevotionAura = value;
            updateDevotionAura?.Invoke(isDevotionAura >= threshold);
        }
    }

    public int IsHealthstone
    {
        get
        {
            return isHealthstone;
        }
        set
        {
            isHealthstone = value;
            updateHealthstone?.Invoke(isHealthstone >= threshold);
        }
    }

    public int IsDeathGrip
    {
        get
        {
            return isDeathGrip;
        }
        set
        {
            isDeathGrip = value;
            updateDeathGrip?.Invoke(isDeathGrip >= threshold);
        }
    }

    // 이벤트 등록 및 해제 메서드를 통해 등록되는 이벤트를 추적 관리
    public void SetBloodlustEvent(UpdateBloodlust bloodlustEvent)
    {
        updateBloodlust += bloodlustEvent;
        updateBloodlust?.Invoke(isBloodlust >= threshold);
    }

    public void SetBattleShoutEvent(UpdateBattleShout battleShoutEvent)
    {
        updateBattleShout += battleShoutEvent;
        updateBattleShout?.Invoke(isBattleShout >= threshold);
    }

    public void SetPowerWordFortitudeEvent(UpdatePowerWordFortitude powerWordFortitudeEvent)
    {
        updatePowerWordFortitude += powerWordFortitudeEvent;
        updatePowerWordFortitude?.Invoke(isPowerWordFortitude >= threshold);
    }

    public void SetArcaneIntellectEvent(UpdateArcaneIntellect arcaneIntellectEvent)
    {
        updateArcaneIntellect += arcaneIntellectEvent;
        updateArcaneIntellect?.Invoke(isArcaneIntellect >= threshold);
    }

    public void SetSkyfuryEvent(UpdateSkyfury skyfuryEvent)
    {
        updateSkyfury += skyfuryEvent;
        updateSkyfury?.Invoke(isSkyfury >= threshold);
    }

    public void SetMarkoftheWildEvent(UpdateMarkoftheWild markoftheWildEvent)
    {
        updateMarkoftheWild += markoftheWildEvent;
        updateMarkoftheWild?.Invoke(isMarkoftheWild >= threshold);
    }

    public void SetBlessingoftheBronzeEvent(UpdateBlessingoftheBronze blessingoftheBronzeEvent)
    {
        updateBlessingoftheBronze += blessingoftheBronzeEvent;
        updateBlessingoftheBronze?.Invoke(isBlessingoftheBronze >= threshold);
    }

    public void SetMysticTouchEvent(UpdateMysticTouch mysticTouchEvent)
    {
        updateMysticTouch += mysticTouchEvent;
        updateMysticTouch?.Invoke(isMysticTouch >= threshold);
    }

    public void SetChaosBrandEvent(UpdateChaosBrand chaosBrandEvent)
    {
        updateChaosBrand += chaosBrandEvent;
        updateChaosBrand?.Invoke(isChaosBrand >= threshold);
    }

    public void SetHuntersMarkEvent(UpdateHuntersMark huntersMarkEvent)
    {
        updateHuntersMark += huntersMarkEvent;
        updateHuntersMark?.Invoke(isHuntersMark >= threshold);
    }

    public void SetPoisonEvent(UpdatePoison poisonEvent)
    {
        updatePoison += poisonEvent;
        updatePoison?.Invoke(isPoison >= threshold);
    }

    public void SetDevotionAuraEvent(UpdateDevotionAura devotionAuraEvent)
    {
        updateDevotionAura += devotionAuraEvent;
        updateDevotionAura?.Invoke(isDevotionAura >= threshold);
    }

    public void SetHealthstoneEvent(UpdateHealthstone healthstoneEvent)
    {
        updateHealthstone += healthstoneEvent;
        updateHealthstone?.Invoke(isHealthstone >= threshold);
    }

    public void SetDeathGripEvent(UpdateDeathGrip deathGripEvent)
    {
        updateDeathGrip += deathGripEvent;
        updateDeathGrip?.Invoke(isDeathGrip >= threshold);
    }

    public void RemoveBloodlustEvent(UpdateBloodlust bloodlustEvent)
    {
        updateBloodlust -= bloodlustEvent;
    }

    public void RemoveBattleShoutEvent(UpdateBattleShout battleShoutEvent)
    {
        updateBattleShout -= battleShoutEvent;
    }

    public void RemovePowerWordFortitudeEvent(UpdatePowerWordFortitude powerWordFortitudeEvent)
    {
        updatePowerWordFortitude -= powerWordFortitudeEvent;
    }

    public void RemoveArcaneIntellectEvent(UpdateArcaneIntellect arcaneIntellectEvent)
    {
        updateArcaneIntellect -= arcaneIntellectEvent;
    }

    public void RemoveSkyfuryEvent(UpdateSkyfury skyfuryEvent)
    {
        updateSkyfury -= skyfuryEvent;
    }

    public void RemoveMarkoftheWildEvent(UpdateMarkoftheWild markoftheWildEvent)
    {
        updateMarkoftheWild -= markoftheWildEvent;
    }

    public void RemoveBlessingoftheBronzeEvent(UpdateBlessingoftheBronze blessingoftheBronzeEvent)
    {
        updateBlessingoftheBronze -= blessingoftheBronzeEvent;
    }

    public void RemoveMysticTouchEvent(UpdateMysticTouch mysticTouchEvent)
    {
        updateMysticTouch -= mysticTouchEvent;
    }

    public void RemoveChaosBrandEvent(UpdateChaosBrand chaosBrandEvent)
    {
        updateChaosBrand -= chaosBrandEvent;
    }

    public void RemoveHuntersMarkEvent(UpdateHuntersMark huntersMarkEvent)
    {
        updateHuntersMark -= huntersMarkEvent;
    }

    public void RemovePoisonEvent(UpdatePoison poisonEvent)
    {
        updatePoison -= poisonEvent;
    }

    public void RemoveDevotionAuraEvent(UpdateDevotionAura devotionAuraEvent)
    {
        updateDevotionAura -= devotionAuraEvent;
    }

    public void RemoveHealthstoneEvent(UpdateHealthstone healthstoneEvent)
    {
        updateHealthstone -= healthstoneEvent;
    }

    public void RemoveDeathGripEvent(UpdateDeathGrip deathGripEvent)
    {
        updateDeathGrip -= deathGripEvent;
    }

    protected override void OnDestroy() 
    {
        // 모든 이벤트를 제거
        updateBloodlust = null;
        updateBattleShout = null;
        updatePowerWordFortitude = null;
        updateArcaneIntellect = null;
        updateSkyfury = null;
        updateMarkoftheWild = null;
        updateBlessingoftheBronze = null;
        updateMysticTouch = null;
        updateChaosBrand = null;
        updateHuntersMark = null;
        updatePoison = null;
        updateDevotionAura = null;
        updateHealthstone = null;
        updateDeathGrip = null;

        if (instance == this)
        {
            instance = null;
        }
    }
}
