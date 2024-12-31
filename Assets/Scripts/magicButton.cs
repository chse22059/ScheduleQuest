using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Threading;

public class magicButton : MonoBehaviour
{
    [SerializeField] StatusSO statusSO;
    [SerializeField] StatusEnemySO statusEnemySO;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()
    {
        //statusEnemySO.BattleInfo = "magic";
        statusEnemySO.STAGE = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("magic_select");
    }

    // Update is called once per frame
    void Update()
    {
    }
}

