using UnityEngine;
using System.IO;
using System.Collections.Generic;

public class DataManager : MonoBehaviour
{
    public List<Job> playerData;
    
    public void OnSaveData(List<Job> data)
    {
        // 데이터 저장 과정
        JobListWrapper wrapper = new JobListWrapper { jobs = data };

        var json = JsonUtility.ToJson(wrapper);
        // json = AESWithJava.Con.Program.Encrypt(json, key);  // 암호화
        File.WriteAllText(Application.persistentDataPath + "/UserData.json", json);
    }

    public void OnLoadData()
    {
        // 데이터 로드 과정
        string path = Application.persistentDataPath + "/UserData.json";
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
            Debug.Log("No save data found.");
        }
    }

    private void Start()
    {
        OnLoadData();

        foreach (Job job in playerData)
        {
            Roster.Instance.AddToRoster(job.jobClass, job.role, job.range, job.armor, job.classTalent, true);
        }
        
        Roster.Instance.LoadRoster(playerData);
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            // 세이브 제거
            
        }
    }
}
