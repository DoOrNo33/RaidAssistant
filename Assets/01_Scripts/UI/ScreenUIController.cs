using UnityEngine;
using System.Collections.Generic;

public class ScreenUIController : MonoBehaviour
{
    // TODO: 스크린 전부 끄는 함수 만들기
    [SerializeField] private List<GameObject> screens;

    // enum으로 스크린 관리 필요
    // 입력에서 이넘 받아서 그거는 끄지 않도록 설정해야 함
    public void SetOffAllScreens(int screenType)
    {
        for (int i = 0; i < screens.Count; i++)
        {
            if (i != screenType)
            {
                screens[i].SetActive(false);
            }
        }
    }
}
