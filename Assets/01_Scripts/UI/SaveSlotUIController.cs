using UnityEngine;
using TMPro;

public class SaveSlotUIController : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI saveSlotText;
    private int addedSaveSlotNumber = 1;            // 슬롯 인덱스는 0부터 시작되지만 플레이어에게는 1부터 보여지도록 하기 위해 1을 더함

    private void OnEnable()
    {
        GameManager.Instance.SaveSlotNumberEventHandler.AddUpdateSaveSlotNumberListener(UpdateSaveSlotUI);
    }

    private void UpdateSaveSlotUI(int saveSlotNumber)
    {
        saveSlotText.text = "저장 슬롯: " + (saveSlotNumber + addedSaveSlotNumber).ToString();
    }
}
