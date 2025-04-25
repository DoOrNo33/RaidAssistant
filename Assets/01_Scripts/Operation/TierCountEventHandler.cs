using UnityEngine;

public class TierCountEventHandler
{
    [SerializeField] private int wRMECount = 0;
    [SerializeField] private int pPSCount  = 0;
    [SerializeField] private int hMDCount  = 0;
    [SerializeField] private int dWDCount  = 0;

    public delegate void UpdateWRMECount(int value);
    public delegate void UpdatePPSCount(int value);
    public delegate void UpdateHMDCount(int value);
    public delegate void UpdateDWDCount(int value);

    private event UpdateWRMECount updateWRMECount;
    private event UpdatePPSCount updatePPSCount;
    private event UpdateHMDCount updateHMDCount;
    private event UpdateDWDCount updateDWDCount;
    
    public int WRMECount
    {
        get
        {
            return wRMECount;
        }
        set
        {
            wRMECount = value;
            updateWRMECount?.Invoke(wRMECount);
        }
    }

    public int PPSCount
    {
        get
        {
            return pPSCount;
        }
        set
        {
            pPSCount = value;
            updatePPSCount?.Invoke(pPSCount);
        }
    }

    public int HMDCount
    {
        get
        {
            return hMDCount;
        }
        set
        {
            hMDCount = value;
            updateHMDCount?.Invoke(hMDCount);
        }
    }

    public int DWDCount
    {
        get
        {
            return dWDCount;
        }
        set
        {
            dWDCount = value;
            updateDWDCount?.Invoke(dWDCount);
        }
    }

    public void SetWRMEEvent(UpdateWRMECount action)
    {
        updateWRMECount += action;
        updateWRMECount?.Invoke(WRMECount);
    }

    public void SetPPSCountEvent(UpdatePPSCount action)
    {
        updatePPSCount += action;
        updatePPSCount?.Invoke(PPSCount);
    }

    public void SetHMDCountEvent(UpdateHMDCount action)
    {
        updateHMDCount += action;
        updateHMDCount?.Invoke(HMDCount);
    }

    public void SetDWDCountEvent(UpdateDWDCount action)
    {
        updateDWDCount += action;
        updateDWDCount?.Invoke(DWDCount);
    }

    public void RemoveWRMEEvent(UpdateWRMECount action)
    {
        updateWRMECount -= action;
    }

    public void RemovePPSCountEvent(UpdatePPSCount action)
    {
        updatePPSCount -= action;
    }

    public void RemoveHMDCountEvent(UpdateHMDCount action)
    {
        updateHMDCount -= action;
    }

    public void RemoveDWDCountEvent(UpdateDWDCount action)
    {
        updateDWDCount -= action;
    }

    protected void OnDestroy() 
    {
        Cleanup();
    }

    public void Cleanup()
    {
        // 모든 이벤트를 제거
        updateWRMECount = null;
        updatePPSCount = null;
        updateHMDCount = null;
        updateDWDCount = null;
    }
}
