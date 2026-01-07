using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;
    void Start()
    {
        //TODO:
        // - 플레이어 Save / Load
        // - Save 없으면: 플레이어를 등록 씬으로 Redirection
        // - 백엔드를 호출하고 일일 챌린지와 보상 얻기

        _sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @: " + DateTime.Now);
    }

    private void OnApplicationQuit()
    {
        _sessionEndTime = DateTime.Now;
        TimeSpan timeDifference = _sessionEndTime.Subtract(_sessionStartTime);

        Debug.Log("Game session ended @: " + DateTime.Now);
        Debug.Log("Game sesson lasted @: " + timeDifference);
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void Update()
    {
        
    }
}
