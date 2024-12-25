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
        // totalEXP が 1 以上の場合のみ処理を実行
        if (EXP.totalEXP > 0)
        {
            EXP.totalEXP--;       // totalEXP をデクリメント
            incrementAction();    // 指定されたパラメータをインクリメント
        }
        else
        {
            Debug.Log("Not enough EXP!"); // デバッグログで通知
        }
    }
}


