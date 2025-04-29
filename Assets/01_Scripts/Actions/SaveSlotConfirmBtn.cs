using UnityEngine;
using TMPro;

public class SaveSlotConfirmBtn : MonoBehaviour
{
    // SaveSlot 클래스를 사용하여 슬롯을 로드하고 초기화하는 버튼
    // SaveSlot 클래스를 외부에서 삽입해주고 public 메서드로 SaveSlot 클래스를 호출

    [SerializeField] private SaveSlot saveSlot;
    [SerializeField] private TextMeshProUGUI confirmText; // 안내 텍스트
    private int addedSaveSlotNumber = 1;            // 슬롯 인덱스는 0부터 시작되지만 플레이어에게는 1부터 보여지도록 하기 위해 1을 더함

    public void SetSaveSlot(SaveSlot slot)
    {
        saveSlot = slot;

        // 다국어 설정의 경우 적용 방법 필요함
        confirmText.text = $"슬롯 " + (slot.SlotIndex + addedSaveSlotNumber) + "을 초기화\r\n하시겠습니까?";
    }

    public void ConcirmBtn()
    {
        if (saveSlot != null)
        {
            saveSlot.ClearSlot(); // 슬롯 초기화
        }
        else
        {
            Debug.LogError("SaveSlot is not assigned.");
        }
    }
}
