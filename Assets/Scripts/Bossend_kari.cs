using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class Bossend_kari : MonoBehaviour
    {   
    [SerializeField]
    private string sceneName;
    public string SceneName => sceneName;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()//倒したと仮定 
    {   
        GameManager.Instance.isBossDefeated = true;
        SceneManager.LoadScene(SceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}