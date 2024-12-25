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
        if(statusSO.MP >= 10)
        {
            statusSO.ATK += 20;
            statusSO.MP -= 10;
            statusEnemySO.BattleInfo = "magic";
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}

