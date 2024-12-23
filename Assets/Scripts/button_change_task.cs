using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class button_change_task : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()
    {
        SceneManager.LoadScene("todolist");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
