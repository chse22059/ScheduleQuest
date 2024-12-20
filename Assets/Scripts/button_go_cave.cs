using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_go_cave : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push() {
      SceneManager.LoadScene("cave");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
