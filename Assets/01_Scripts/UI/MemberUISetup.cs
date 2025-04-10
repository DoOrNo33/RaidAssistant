using UnityEngine;
using TMPro;

public class MemberUISetup : MonoBehaviour
{
    // 로스터 인원수를 보여주는 UI를 통제
    [SerializeField] private TextMeshProUGUI tankCountUI;
    [SerializeField] private TextMeshProUGUI meleeCountUI;
    [SerializeField] private TextMeshProUGUI rangedCountUI;
    [SerializeField] private TextMeshProUGUI healerCountUI;
    [SerializeField] private TextMeshProUGUI totalCountUI;

    private void OnEnable()
    {
        // MemberCountEventHandler의 이벤트를 구독해서 멤버 수를 업데이트
        MemberCountEventHandler.Instance.SetTankEvent(UpdateTankCount);
        MemberCountEventHandler.Instance.SetMeleeEvent(UpdateMeleeCount);
        MemberCountEventHandler.Instance.SetRangedEvent(UpdateRangedCount);
        MemberCountEventHandler.Instance.SetHealerEvent(UpdateHealerCount);
        MemberCountEventHandler.Instance.SetTotalEvent(UpdateTotalCount);
    }
    
    private void UpdateTankCount(int value)
    {
        tankCountUI.text = value.ToString();
    }

    private void UpdateMeleeCount(int value)
    {
        meleeCountUI.text = value.ToString();
    }

    private void UpdateRangedCount(int value)
    {
        rangedCountUI.text = value.ToString();
    }

    private void UpdateHealerCount(int value)
    {
        healerCountUI.text = value.ToString();
    }

    private void UpdateTotalCount(int value)
    {
        totalCountUI.text = value.ToString();
    }
}
