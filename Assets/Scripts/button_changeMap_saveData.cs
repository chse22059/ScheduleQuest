using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_changeMap_saveData : MonoBehaviour
{
    [SerializeField]
    private string sceneName;
    public string SceneName => sceneName;

    public InputFieldManager inputFieldManager; // InputFieldManagerの参照を追加

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()
    {
        // シーン遷移前に入力フィールドの内容を保存
        inputFieldManager.SaveInputText();

        // シーン遷移
        SceneManager.LoadScene(SceneName);
    }
}

