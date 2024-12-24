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
            // ���Ԃ�i�߂�
            elapsedTime += Time.deltaTime;

            // 30�b���ƂɃJ�E���g�𑝉�
            if (Mathf.FloorToInt(elapsedTime) % 30 == 0 && Mathf.FloorToInt(elapsedTime) != Mathf.FloorToInt(elapsedTime - Time.deltaTime))
            {
                GTD.totalEXP += 1;
            }
        }

        // �o�ߎ��Ԃ𕶎���ɂ��ĕ\��
        timerText.text = "Time: " + elapsedTime.ToString("F2");  // �����_�ȉ�2���ŕ\��
    }

    // �^�C�}�[�J�n
    public void StartTimer()
    {
        isRunning = true;
    }

    // �^�C�}�[��~
    public void StopTimer()
    {
        isRunning = false;
    }
}


