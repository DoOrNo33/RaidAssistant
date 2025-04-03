using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class SquareButtonResizer : MonoBehaviour
{
    [SerializeField]  RectTransform rectTransform;

    private void Update()
    {
        //버튼의 높이를 가져와 가로 길이를 돌일하게 설정
        float height = rectTransform.rect.height;
        rectTransform.sizeDelta = new Vector2(height, height);
    }
}
