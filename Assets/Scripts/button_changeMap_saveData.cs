using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_changeMap_saveData : MonoBehaviour
{
    [SerializeField]
    private string sceneName;
    public string SceneName => sceneName;

    public InputFieldManager inputFieldManager; // InputFieldManager�̎Q�Ƃ�ǉ�

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()
    {
        // �V�[���J�ڑO�ɓ��̓t�B�[���h�̓��e��ۑ�
        inputFieldManager.SaveInputText();

        // �V�[���J��
        SceneManager.LoadScene(SceneName);
    }
}

