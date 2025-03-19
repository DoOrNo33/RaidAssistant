using UnityEngine;

public class AddRosterBtn : MonoBehaviour
{
    [SerializeField] private Enums.Class jobClass; 

    public void ClickAddBtn()
    {
        Roster.Instance.AddToRoster(jobClass);
        
    }
}
