using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;


public class magicButton : MonoBehaviour
{
    [SerializeField] StatusEnemySO statusEnemySO;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()
    {
        statusEnemySO.STAGE = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("magic_select");
    }

    // Update is called once per frame
    void Update()
    {
    }
}

