using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_go_fire : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push() {
      SceneManager.LoadScene("fire");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
