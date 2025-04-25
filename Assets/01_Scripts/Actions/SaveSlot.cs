using UnityEngine;

public class SaveSlot : MonoBehaviour
{
    [SerializeField] private int slotIndex = 0;
    [SerializeField] private DataManager dataManager;

    public void LoadSlot()
    {
        // 세이브 슬롯 저장
        dataManager.ChangeSlot(slotIndex);

        dataManager.OnLoadData();

        dataManager.ResetRoster();
    }
}
