using UnityEngine;

public class MemberCountEventHandler : Singleton<MemberCountEventHandler>
{
    [SerializeField] private int tankCount = 0;
    [SerializeField] private int meleeCount  = 0;
    [SerializeField] private int rangedCount  = 0;
    [SerializeField] private int healerCount  = 0;
    [SerializeField] private int totalCount  = 0;

    public delegate void UpdateTankCount(int value);
    public delegate void UpdateMeleeCount(int value);
    public delegate void UpdateRangedCount(int value);
    public delegate void UpdateHealerCount(int value);
    public delegate void UpdateTotalCount(int value);

    private event UpdateTankCount updateTankCount;
    private event UpdateMeleeCount updateMeleeCount;
    private event UpdateRangedCount updateRangedCount;
    private event UpdateHealerCount updateHealerCount;
    private event UpdateTotalCount updateTotalCount;
    
    public int TankCount
    {
        get
        {
            return tankCount;
        }
        set
        {
            tankCount = value;
            updateTankCount?.Invoke(tankCount);

            // 총 인원 수 업데이트
            TotalCount = tankCount + meleeCount + rangedCount + healerCount;
            updateTotalCount?.Invoke(totalCount);
        }
    }

    public int MeleeCount
    {
        get
        {
            return meleeCount;
        }
        set
        {
            meleeCount = value;
            updateMeleeCount?.Invoke(meleeCount);

            // 총 인원 수 업데이트
            TotalCount = tankCount + meleeCount + rangedCount + healerCount;
            updateTotalCount?.Invoke(totalCount);
        }
    }

    public int RangedCount
    {
        get
        {
            return rangedCount;
        }
        set
        {
            rangedCount = value;
            updateRangedCount?.Invoke(rangedCount);

            // 총 인원 수 업데이트
            TotalCount = tankCount + meleeCount + rangedCount + healerCount;
            updateTotalCount?.Invoke(totalCount);
        }
    }

    public int HealerCount
    {
        get
        {
            return healerCount;
        }
        set
        {
            healerCount = value;
            updateHealerCount?.Invoke(healerCount);

            // 총 인원 수 업데이트
            TotalCount = tankCount + meleeCount + rangedCount + healerCount;
            updateTotalCount?.Invoke(totalCount);
        }
    }

    public int TotalCount
    {
        get
        {
            return totalCount;
        }
        set
        {
            totalCount = value;
            updateTotalCount?.Invoke(totalCount);
        }
    }

    public void SetTankEvent(UpdateTankCount action)
    {
        updateTankCount += action;
        updateTankCount?.Invoke(tankCount);
    }

    public void SetMeleeEvent(UpdateMeleeCount action)
    {
        updateMeleeCount += action;
        updateMeleeCount?.Invoke(meleeCount);
    }

    public void SetRangedEvent(UpdateRangedCount action)
    {
        updateRangedCount += action;
        updateRangedCount?.Invoke(rangedCount);
    }

    public void SetHealerEvent(UpdateHealerCount action)
    {
        updateHealerCount += action;
        updateHealerCount?.Invoke(healerCount);
    }

    public void SetTotalEvent(UpdateTotalCount action)
    {
        updateTotalCount += action;
        updateTotalCount?.Invoke(totalCount);
    }

    public void RemoveTankEvent(UpdateTankCount action)
    {
        updateTankCount -= action;
    }

    public void RemoveMeleeEvent(UpdateMeleeCount action)
    {
        updateMeleeCount -= action;
    }

    public void RemoveRangedEvent(UpdateRangedCount action)
    {
        updateRangedCount -= action;
    }

    public void RemoveHealerEvent(UpdateHealerCount action)
    {
        updateHealerCount -= action;
    }

    public void RemoveTotalEvent(UpdateTotalCount action)
    {
        updateTotalCount -= action;
    }

    protected override void OnDestroy() 
    {
        // 모든 이벤트를 제거
        updateTankCount = null;
        updateMeleeCount = null;
        updateRangedCount = null;
        updateHealerCount = null;
        updateTotalCount = null;

        if (instance == this)
        {
            instance = null;
        }
    }
}
