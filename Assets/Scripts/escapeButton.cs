using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class escapeButton : MonoBehaviour
{
    public string preScene = "";//前のシーン受け取り変数
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push() {
      SceneManager.LoadScene(preScene);//前のシーンへ移動
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
