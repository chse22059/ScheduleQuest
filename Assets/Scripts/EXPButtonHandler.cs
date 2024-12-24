using UnityEngine;
using UnityEngine.UI;

public class EXPButtonHandler : MonoBehaviour
{
    public GlobalTimerDataSO EXP;
    public StatusSO statusSO;

    public Button hpButton;
    public Button mpButton;
    public Button atkButton;
    public Button equipButton;
    public Button goldButton;

    void Start()
    {
        hpButton.onClick.AddListener(() => HandleButtonClick(() => statusSO.HP++));
        mpButton.onClick.AddListener(() => HandleButtonClick(() => statusSO.MP++));
        atkButton.onClick.AddListener(() => HandleButtonClick(() => statusSO.ATK++));
        equipButton.onClick.AddListener(() => HandleButtonClick(() => statusSO.EQUIP++));
        goldButton.onClick.AddListener(() => HandleButtonClick(() => statusSO.GOLD++));
    }

    void HandleButtonClick(System.Action incrementAction)
    {
        // totalEXP �� 1 �ȏ�̏ꍇ�̂ݏ��������s
        if (EXP.totalEXP > 0)
        {
            EXP.totalEXP--;       // totalEXP ���f�N�������g
            incrementAction();    // �w�肳�ꂽ�p�����[�^���C���N�������g
        }
        else
        {
            Debug.Log("Not enough EXP!"); // �f�o�b�O���O�Œʒm
        }
    }
}


