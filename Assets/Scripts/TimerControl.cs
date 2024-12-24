using UnityEngine;
using UnityEngine.UI;

public class TimerControl : MonoBehaviour
{
    public TimerDisplay timerDisplay;  // TimerDisplay�X�N���v�g�̎Q��
    public Button startButton;         // �X�^�[�g�{�^��
    public Button stopButton;          // �X�g�b�v�{�^��

    void Start()
    {
        // �X�^�[�g�{�^�����N���b�N���ꂽ�Ƃ��Ƀ^�C�}�[�J�n
        startButton.onClick.AddListener(StartTimer);
        // �X�g�b�v�{�^�����N���b�N���ꂽ�Ƃ��Ƀ^�C�}�[��~
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
