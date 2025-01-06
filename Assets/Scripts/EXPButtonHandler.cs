/*
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
*/

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
        statusSO.LoadStatus();

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
            EXP.SaveEXP();
            SaveStatus();
        }
        else
        {
            Debug.Log("Not enough EXP!"); // �f�o�b�O���O�Œʒm
        }
    }

    private void SaveStatus()
    {
        PlayerPrefs.SetInt("TotalEXP", EXP.totalEXP);
        PlayerPrefs.SetInt("HP", statusSO.HP);
        PlayerPrefs.SetInt("MP", statusSO.MP);
        PlayerPrefs.SetInt("ATK", statusSO.ATK);
        PlayerPrefs.SetInt("EQUIP", statusSO.EQUIP);
        PlayerPrefs.SetInt("Gold", statusSO.GOLD);

        PlayerPrefs.Save();
    }

    private void LoadStatus()
    {
        EXP.totalEXP = PlayerPrefs.GetInt("TotalEXP", EXP.totalEXP);
        statusSO.HP = PlayerPrefs.GetInt("HP", statusSO.HP);
        statusSO.MP = PlayerPrefs.GetInt("MP", statusSO.MP);
        statusSO.ATK = PlayerPrefs.GetInt("ATK", statusSO.ATK);
        statusSO.EQUIP = PlayerPrefs.GetInt("EQUIP", statusSO.EQUIP);
        statusSO.GOLD = PlayerPrefs.GetInt("Gold", statusSO.GOLD);
    }
}




