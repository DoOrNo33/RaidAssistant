using UnityEngine;

public class SaveSlot : MonoBehaviour
{
    [SerializeField] private int slotIndex = 0;
    [SerializeField] private DataManager dataManager;
    [SerializeField] private SaveSlotConfirmBtn confirmBtn;
    private int addedSaveSlotNumber = 1;            // 슬롯 인덱스는 0부터 시작되지만 플레이어에게는 1부터 보여지도록 하기 위해 1을 더함

    public int SlotIndex
    {
        get { return slotIndex; }
    }

    public void LoadSlot()
    {
        dataManager.ResetRoster(slotIndex);         // 슬롯 인덱스를 넘겨서 세이브 슬롯 변경
    }

    public void ClearSlot()
    {
        dataManager.ClearSaveSlot(slotIndex);       // 슬롯 인덱스를 넘겨서 세이브 슬롯 초기화

        Debug.Log($"Slot {slotIndex + addedSaveSlotNumber} cleared."); // 슬롯 초기화 완료 로그
    }

    public void UpdateSlotUI()
    {
        // 슬롯 UI 업데이트
        GameManager.Instance.SaveSlotNumberEventHandler.SaveSlotNumber = slotIndex;
    }

    public void UpdateConfirmBtn()
    {
        confirmBtn.SetSaveSlot(this);               // 슬롯 인덱스를 넘겨서 세이브 슬롯 초기화
    }
}
