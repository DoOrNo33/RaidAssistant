using UnityEngine;
using System.Collections.Generic;

public class ClassButtonResizerManager : MonoBehaviour
{
    // 버튼 리사이징을 위한 리스트
    [SerializeField] private List<SquareButtonResizer> squareButtonResizers;

    // 실행 후 한번만 호출되도록 불값 설정
    [SerializeField] bool isResized = false;

    public void ResizeButton()
    {
        if (isResized)
            return;

        foreach (SquareButtonResizer resizer in squareButtonResizers)
        {
            resizer.ResizeSetup();
        }
        isResized = true;
    }
}
