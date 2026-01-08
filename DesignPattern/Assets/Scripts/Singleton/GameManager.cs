using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{
    private DateTime _sessionStartTime;
    private DateTime _sessionEndTime;

    private void Start()
    {
        /*
         * TODO:
         * - Player Save & Load
         * - Save File이 없으면: Player를 등록Scene으로 Redirection
         * - Backend 호출 후 일일 챌린지와 보상을 얻음
         */

        _sessionStartTime = DateTime.Now;
        Debug.Log("Game session start @: " + DateTime.Now);
    }

    private void OnApplicationQuit()
    {
        _sessionEndTime = DateTime.Now;

        TimeSpan timeDifference = _sessionEndTime.Subtract(_sessionStartTime);

        Debug.Log("Game session ended @: " + DateTime.Now);
        Debug.Log("Game session lasted: " + timeDifference);
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(
                SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
