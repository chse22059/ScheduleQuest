using UnityEngine;
using UnityEngine.UI;

public class TimerControl : MonoBehaviour
{
    public TimerDisplay timerDisplay;  // TimerDisplayスクリプトの参照
    public Button startButton;         // スタートボタン
    public Button stopButton;          // ストップボタン

    void Start()
    {
        // スタートボタンがクリックされたときにタイマー開始
        startButton.onClick.AddListener(StartTimer);
        // ストップボタンがクリックされたときにタイマー停止
        stopButton.onClick.AddListener(StopTimer);
    }

    void StartTimer()
    {
        timerDisplay.StartTimer();
    }

    void StopTimer()
    {
        timerDisplay.StopTimer();
    }
}
