using UnityEngine;

public class ArmourCountEventHandler
{
    [SerializeField] private int plateCount = 0;
    [SerializeField] private int mailCount  = 0;
    [SerializeField] private int leatherCount  = 0;
    [SerializeField] private int clothCount  = 0;

    public delegate void UpdatePlateCount(int value);
    public delegate void UpdateMailCount(int value);
    public delegate void UpdateLeatherCount(int value);
    public delegate void UpdateClothCount(int value);

    private event UpdatePlateCount updatePlateCount;
    private event UpdateMailCount updateMailCount;
    private event UpdateLeatherCount updateLeatherCount;
    private event UpdateClothCount updateClothCount;
    
    public int PlateCount
    {
        get
        {
            return plateCount;
        }
        set
        {
            plateCount = value;
            updatePlateCount?.Invoke(PlateCount);
        }
    }

    public int MailCount
    {
        get
        {
            return mailCount;
        }
        set
        {
            mailCount = value;
            updateMailCount?.Invoke(MailCount);
        }
    }

    public int LeatherCount
    {
        get
        {
            return leatherCount;
        }
        set
        {
            leatherCount = value;
            updateLeatherCount?.Invoke(LeatherCount);
        }
    }

    public int ClothCount
    {
        get
        {
            return clothCount;
        }
        set
        {
            clothCount = value;
            updateClothCount?.Invoke(ClothCount);
        }
    }

    public void SetPlateEvent(UpdatePlateCount action)
    {
        updatePlateCount += action;
        updatePlateCount?.Invoke(PlateCount);
    }

    public void SetMailEvent(UpdateMailCount action)
    {
        updateMailCount += action;
        updateMailCount?.Invoke(MailCount);
    }

    public void SetLeatherEvent(UpdateLeatherCount action)
    {
        updateLeatherCount += action;
        updateLeatherCount?.Invoke(LeatherCount);
    }

    public void SetClothEvent(UpdateClothCount action)
    {
        updateClothCount += action;
        updateClothCount?.Invoke(ClothCount);
    }

    public void RemovePlateEvent(UpdatePlateCount action)
    {
        updatePlateCount -= action;
    }

    public void RemoveMailEvent(UpdateMailCount action)
    {
        updateMailCount -= action;
    }

    public void RemoveLeatherEvent(UpdateLeatherCount action)
    {
        updateLeatherCount -= action;
    }

    public void RemoveClothEvent(UpdateClothCount action)
    {
        updateClothCount -= action;
    }

    private void OnDestroy()
    {
        Cleanup();
    }

    public void Cleanup()
    {
        // 모든 이벤트를 제거
        updatePlateCount = null;
        updateMailCount = null;
        updateLeatherCount = null;
        updateClothCount = null;
    }
}
