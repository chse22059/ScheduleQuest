using UnityEngine;
using TMPro; // TextMeshPro�̖��O���

public class InputFieldManager : MonoBehaviour
{
    // 3��TMP_InputField���Ǘ�
    public TMP_InputField inputField1;
    public TMP_InputField inputField2;
    public TMP_InputField inputField3;

    // �e�t�B�[���h�̕ۑ��L�[
    private const string PlayerPrefKey1 = "TMPInputFieldData1";
    private const string PlayerPrefKey2 = "TMPInputFieldData2";
    private const string PlayerPrefKey3 = "TMPInputFieldData3";

    void Start()
    {
        // �V�[���J�n���ɕۑ����ꂽ���e�𕜌�
        if (PlayerPrefs.HasKey(PlayerPrefKey1))
        {
            inputField1.text = PlayerPrefs.GetString(PlayerPrefKey1); // �ۑ��f�[�^1�𕜌�
        }
        if (PlayerPrefs.HasKey(PlayerPrefKey2))
        {
            inputField2.text = PlayerPrefs.GetString(PlayerPrefKey2); // �ۑ��f�[�^2�𕜌�
        }
        if (PlayerPrefs.HasKey(PlayerPrefKey3))
        {
            inputField3.text = PlayerPrefs.GetString(PlayerPrefKey3); // �ۑ��f�[�^3�𕜌�
        }
    }

    public void SaveInputText()
    {
        // �eTMP_InputField�̓��e��ۑ�
        PlayerPrefs.SetString(PlayerPrefKey1, inputField1.text);
        PlayerPrefs.SetString(PlayerPrefKey2, inputField2.text);
        PlayerPrefs.SetString(PlayerPrefKey3, inputField3.text);

        PlayerPrefs.Save(); // PlayerPrefs�Ɋm��ۑ�
    }
}
