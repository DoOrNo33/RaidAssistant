using UnityEngine;
using UnityEngine.Events;

public class BaseUI : MonoBehaviour
{
    public UnityAction<object[]> opened;
    public UnityAction<object[]> closed;

    private void Awake()
    {
        opened = OnOpened;
        closed = OnClosed;
    }

    //SetActive 함수를 GameObject가 아닌 UI에서 쓸수있도록 함수 선언
    public void SetActive(bool isActive)
    {
        gameObject.SetActive(isActive);
    }

    //SetActive 함수 오버로딩: 버튼 하나로 작동하도록 함수 선언
    public void SetActive()
    {
        if (gameObject.activeSelf)
        {
            gameObject.SetActive(false);
        }
        else{
            gameObject.SetActive(true);
        }
    }

    //UI를 여는 가상함수 구현
    public virtual void OnOpened(object[] param) { }

    //UI를 닫는 가상함수 구현
    public virtual void OnClosed(object[] param) { }

    //UI를 비활성화 하는 가상함수 구현
    public virtual void HideDirect() { }
}
