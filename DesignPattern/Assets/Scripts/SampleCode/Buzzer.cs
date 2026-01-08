using UnityEngine;

public class Buzzer : MonoBehaviour
{
    private void OnEnable()
    {
        // Timer class에 선언한 delegate에 local method 할당
        CountdownTimer.OnTimerStarted += PlayStartBuzzer;
        CountdownTimer.OnTimerEnded += PlayEndBuzzer;
    }

    private void OnDisable()
    {
        CountdownTimer.OnTimerStarted -= PlayStartBuzzer;
        CountdownTimer.OnTimerEnded -= PlayEndBuzzer;
    }

    void PlayStartBuzzer()
    {
        Debug.Log("[BUZZER]: Play start buzzer.");
    }

    void PlayEndBuzzer()
    {
        Debug.Log("[BUZZER]: Play end buzzer.");
    }
}
