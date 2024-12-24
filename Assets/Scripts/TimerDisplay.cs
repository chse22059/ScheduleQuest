using UnityEngine;
using UnityEngine.UI;  
using TMPro;          

public class TimerDisplay : MonoBehaviour
{
    public GlobalTimerDataSO GTD;

    public TMP_Text timerText;  
    

    private float elapsedTime = 0f;  
    private bool isRunning = false; 

    void Update()
    {
        if (isRunning)
        {
            // 時間を進める
            elapsedTime += Time.deltaTime;

            // 30秒ごとにカウントを増加
            if (Mathf.FloorToInt(elapsedTime) % 30 == 0 && Mathf.FloorToInt(elapsedTime) != Mathf.FloorToInt(elapsedTime - Time.deltaTime))
            {
                GTD.totalEXP += 1;
            }
        }

        // 経過時間を文字列にして表示
        timerText.text = "Time: " + elapsedTime.ToString("F2");  // 小数点以下2桁で表示
    }

    // タイマー開始
    public void StartTimer()
    {
        isRunning = true;
    }

    // タイマー停止
    public void StopTimer()
    {
        isRunning = false;
    }
}


