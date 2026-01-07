using UnityEngine;
using System.Collections;
using NUnit.Framework.Constraints;

public class CountdownTimer : MonoBehaviour
{
    public delegate void TimerStarted();
    public static event TimerStarted OnTimerStarted;
    public delegate void TimerEnded();
    public static event TimerEnded OnTimerEnded;

    public static WaitForSeconds waitFor1Second = new WaitForSeconds(1f);

    [SerializeField]
    private float duration = 5.0f;
    private float _duration = 10.0f;

    Rect labelRect = new Rect(125, 9, 1000, 20);
    string labelString;

    private IEnumerator Start()
    {
        yield return StartCoroutine(StartCountDown());
        yield return StartCoroutine(WaitAndPrint(1.0F));
    }

    private IEnumerator StartCountDown()
    {
        if (OnTimerStarted != null)
        {
            OnTimerStarted();
        }

        while (duration > 0)
        {
            yield return waitFor1Second;
            duration--;
            labelString = "Count Down: " + duration;
        }

        if (OnTimerEnded != null)
        {
            OnTimerEnded();
        }
    }

    IEnumerator WaitAndPrint(float waitTime)
    {
        Debug.Log("Wait and Print Timer Started.");

        while (Time.time < _duration)
        {
            yield return new WaitForSeconds(waitTime);
            labelString = "Seconds: " + Mathf.Round(Time.time);
        }

        Debug.Log("Wait and Print Timer Ended.");
    }

    private void OnGUI()
    {
        GUI.color = Color.blue;
        GUI.Label(labelRect, labelString);
    }
}
