using UnityEngine;
using TMPro;

public class TierUIController : MonoBehaviour
{
    // 로스터 인원수를 보여주는 UI를 통제
    [SerializeField] private TextMeshProUGUI wRMECountUI;
    [SerializeField] private TextMeshProUGUI pPSCountUI;
    [SerializeField] private TextMeshProUGUI hMDCountUI;
    [SerializeField] private TextMeshProUGUI dWDCountUI;

    private void OnEnable()
    {
        // TierCountEventHandler의 이벤트를 구독해서 멤버 수를 업데이트
        GameManager.Instance.TierCountEventHandler.SetWRMEEvent(UpdateWRMECount);
        GameManager.Instance.TierCountEventHandler.SetPPSCountEvent(UpdatePPSCount);
        GameManager.Instance.TierCountEventHandler.SetHMDCountEvent(UpdateHMDCount);
        GameManager.Instance.TierCountEventHandler.SetDWDCountEvent(UpdateDWDCount);
    }

    // private void OnDisable() 
    // {
    //     // 이벤트 구독 해제
    //     GameManager.Instance.TierCountEventHandler.RemoveWRMEEvent(UpdateWRMECount);
    //     GameManager.Instance.TierCountEventHandler.RemovePPSCountEvent(UpdatePPSCount);
    //     GameManager.Instance.TierCountEventHandler.RemoveHMDCountEvent(UpdateHMDCount);
    //     GameManager.Instance.TierCountEventHandler.RemoveDWDCountEvent(UpdateDWDCount);
    // }

    private void UpdateWRMECount(int value)
    {
        wRMECountUI.text = value.ToString();
    }

    private void UpdatePPSCount(int value)
    {
        pPSCountUI.text = value.ToString();
    }

    private void UpdateHMDCount(int value)
    {
        hMDCountUI.text = value.ToString();
    }

    private void UpdateDWDCount(int value)
    {
        dWDCountUI.text = value.ToString();
    }
}
