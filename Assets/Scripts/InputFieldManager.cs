using UnityEngine;
using TMPro; // TextMeshProの名前空間

public class InputFieldManager : MonoBehaviour
{
    // 3つのTMP_InputFieldを管理
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;

    // 各フィールドの保存キー
    private const string PlayerPrefKey1 = "TMPInputFieldData1";
    private const string PlayerPrefKey2 = "TMPInputFieldData2";
    private const string PlayerPrefKey3 = "TMPInputFieldData3";

    void Start()
    {
        // シーン開始時に保存された内容を復元
        if (PlayerPrefs.HasKey(PlayerPrefKey1))
        {
            inputField1.text = PlayerPrefs.GetString(PlayerPrefKey1); // 保存データ1を復元
        }
        if (PlayerPrefs.HasKey(PlayerPrefKey2))
        {
            inputField2.text = PlayerPrefs.GetString(PlayerPrefKey2); // 保存データ2を復元
        }
        if (PlayerPrefs.HasKey(PlayerPrefKey3))
        {
            inputField3.text = PlayerPrefs.GetString(PlayerPrefKey3); // 保存データ3を復元
        }
    }

    public void SaveInputText()
    {
        // 各TMP_InputFieldの内容を保存
        PlayerPrefs.SetString(PlayerPrefKey1, inputField1.text);
        PlayerPrefs.SetString(PlayerPrefKey2, inputField2.text);
        PlayerPrefs.SetString(PlayerPrefKey3, inputField3.text);

        PlayerPrefs.Save(); // PlayerPrefsに確定保存
    }
}
