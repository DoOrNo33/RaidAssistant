using UnityEngine;
using System.Collections.Generic;

public class ClassSorter : MonoBehaviour
{
    [SerializeField] private List<Job> roster;

    // 로스터 추가 함수
    public void AddToRoster(Job jb)
    {
        roster.Add(jb);
        InsertionSort();
        UpdateObjectHierarchy();
    }

    // 로스터 제거 함수

    // 로스터 정렬 함수
    // 로스터는 enuums에 따라 정렬됨.
    // 정렬된 로스터 대로 오브젝트도 실제로 정렬되어야함.
    private void InsertionSort()
    {
        for (int i =1 ; i < roster.Count; i++)
        {
            Job key = roster[i];
            int j = i - 1;

            while (j >= 0 && (roster[j].classTalent > key.classTalent))
            {
                roster[j + 1] = roster[j];
                j--;
            }

            roster[j + 1] = key;
        }
    }

    // 로스터 정렬 후 오브젝트 정렬
    private void UpdateObjectHierarchy()
    {
        for (int i = 0; i < roster.Count; i++)
        {
            GameObject obj = roster[i].AssociatedObject;
            if (obj != null)
            {
                obj.transform.SetSiblingIndex(i);
            }
        }
    }
}
