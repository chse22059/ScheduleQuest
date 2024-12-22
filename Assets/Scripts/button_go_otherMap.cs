using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class button_go_otherMap : MonoBehaviour
    {   
    [SerializeField]
    private string sceneName;
    public string SceneName => sceneName;

    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push() 
    {
        SceneManager.LoadScene(SceneName,LoadSceneMode.Single);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
