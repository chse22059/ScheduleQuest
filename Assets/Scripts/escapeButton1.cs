using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

    public class escapeButton1 : MonoBehaviour
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
        SceneManager.LoadScene(SceneName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
