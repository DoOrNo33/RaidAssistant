using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class DataManager : MonoBehaviour
{
    public List<Job> playerData;

    private int curSlot = 0;

    private void Awake()
    {
        // 슬롯 번호 로드
        curSlot = LoadSlot();
        Debug.Log($"Current slot: {curSlot}");
    }

    private void Start()
    {
        // 슬롯 번호 로드 된 후 로드되어야 함
        OnLoadData();

        foreach (Job job in playerData)
        {
            Roster.Instance.AddToRoster(job.jobClass, job.role, job.range, job.armor, job.classTalent, true);
        }

    //Roster.Instance.LoadRoster(playerData);

    // 저장 위치 디버그로그로 출력
    //Debug.Log($"Save file path: {Application.persistentDataPath}");
    //C:/ Users / solem / AppData / LocalLow / DefaultCompany / RaidAssistant
    }

    public void OnSaveData(List<Job> data)
    {
        // 현재 슬롯 저장
        SaveSlot(curSlot);

        // 데이터 저장 과정
        JobListWrapper wrapper = new JobListWrapper { jobs = data };
        wrapper.slot = curSlot;                                         // 슬롯 번호 저장

        var json = JsonUtility.ToJson(wrapper);
        // json = AESWithJava.Con.Program.Encrypt(json, key);  // 암호화
        File.WriteAllText(GetSaveFilePath(curSlot), json);

        Debug.Log($"Data saved to slot {curSlot}");
    }

    public void OnLoadData()
    {
        // 데이터 로드 과정
        string path = GetSaveFilePath(curSlot);
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            // json = AESWithJava.Con.Program.Decrypt(json, key);  // 복호화

            // JSON 역질렬화
            JobListWrapper wrapper = JsonUtility.FromJson<JobListWrapper>(json);
            playerData = wrapper.jobs;
        }
        else
        {
            // 슬롯 데이터가 없다면 새로 생성
            JobListWrapper wrapper = new JobListWrapper();
            wrapper.jobs = new List<Job>(); // 빈 리스트로 초기화
            wrapper.slot = curSlot;                                         // 슬롯 번호 저장

            var json = JsonUtility.ToJson(wrapper);
            // json = AESWithJava.Con.Program.Encrypt(json, key);  // 암호화
            File.WriteAllText(GetSaveFilePath(curSlot), json);

            Debug.Log($"Data saved to slot {curSlot}");

            playerData = wrapper.jobs;
        }
    }

    // 슬롯 번호에 따라 저장 파일 경로 동적 생성
    private string GetSaveFilePath(int slot)
    {
        return Application.persistentDataPath + $"/UserData_Slot{slot}.json";
    }

    // 슬롯 번호 저장
    public void SaveSlot(int slot)
    {
        string path = Application.persistentDataPath + "/RecentSlot.json";
        Slot slotData = new Slot(slot);
        string json = JsonUtility.ToJson(slotData);
        File.WriteAllText(path, json);
    }

    // 슬롯 번호 로드
    private int LoadSlot()
    {
        string path = Application.persistentDataPath + "/RecentSlot.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            Slot slotData = JsonUtility.FromJson<Slot>(json);
            return slotData.recentSlot;
        }
        else
        {
            Debug.Log("No recent slot data found.");
            return 0; // 기본 슬롯 번호
        }
    }

    // 슬롯 버튼을 통해 현재 슬롯 변경
    public void ChangeSlot(int slot)
    {
        curSlot = slot;

        SaveSlot(curSlot);
    }

    // 슬롯이 변경 된 후 기존 로스터 데이터와 오브젝트를 초기화 하고 새로 변경된 로스터로 생성되어야 함
    public void ResetRoster()
    {
        // 로스터 초기화
        Roster.Instance.ResetRoster();

        foreach (Job job in playerData)
        {
            Roster.Instance.AddToRoster(job.jobClass, job.role, job.range, job.armor, job.classTalent, true);
        }
    }
}
