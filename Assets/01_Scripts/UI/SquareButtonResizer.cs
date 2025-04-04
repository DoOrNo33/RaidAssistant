using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class SquareButtonResizer : MonoBehaviour
{
    [SerializeField] private RectTransform rectTransform;

    // 비율을 설정할 수 있는 변수
    [SerializeField] private float ratio = 1.5f;

    // public void ResizeSetup()
    // {
    //     //버튼의 높이를 가져와 가로 길이를 돌일하게 설정
    //     float height = rectTransform.rect.height;
    //     rectTransform.sizeDelta = new Vector2((height * 1.5f), height);
    // }

    private void Update()
    {
        //버튼의 높이를 가져와 가로 길이를 돌일하게 설정
        float height = rectTransform.rect.height;
        rectTransform.sizeDelta = new Vector2((height * 1.5f), height);
    }
}
