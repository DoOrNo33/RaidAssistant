using UnityEngine;
using TMPro;

public class ArmorUIController : MonoBehaviour
{
    // 로스터 인원수를 보여주는 UI를 통제
    [SerializeField] private TextMeshProUGUI plateCountUI;
    [SerializeField] private TextMeshProUGUI mailCountUI;
    [SerializeField] private TextMeshProUGUI leatherCountUI;
    [SerializeField] private TextMeshProUGUI clothCountUI;

    private void OnEnable()
    {
        GameManager.Instance.ArmourCountEventHandler.SetPlateEvent(UpdatePlateCount);
        GameManager.Instance.ArmourCountEventHandler.SetMailEvent(UpdateMailCount);
        GameManager.Instance.ArmourCountEventHandler.SetLeatherEvent(UpdateLeatherCount);
        GameManager.Instance.ArmourCountEventHandler.SetClothEvent(UpdateClothCount);
    }

    private void UpdatePlateCount(int value)
    {
        plateCountUI.text = value.ToString();
    }

    private void UpdateMailCount(int value)
    {
        mailCountUI.text = value.ToString();
    }

    private void UpdateLeatherCount(int value)
    {
        leatherCountUI.text = value.ToString();
    }

    private void UpdateClothCount(int value)
    {
        clothCountUI.text = value.ToString();
    }
}
