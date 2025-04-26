using UnityEngine;

public class SaveSlot : MonoBehaviour
{
    [SerializeField] private int slotIndex = 0;
    [SerializeField] private DataManager dataManager;

    public void LoadSlot()
    {
        dataManager.ResetRoster(slotIndex);         // 슬롯 인덱스를 넘겨서 세이브 슬롯 변경
    }

    public void ClearSlot()
    {
        dataManager.ClearSaveSlot(slotIndex);       // 슬롯 인덱스를 넘겨서 세이브 슬롯 초기화
    }
}
