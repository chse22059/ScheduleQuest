using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using System.Threading;
using System.Collections;

public class Display_Console : MonoBehaviour
{
    [SerializeField] StatusSO statusSO;
    [SerializeField] StatusEnemySO statusEnemySO;
    [SerializeField] TextMeshProUGUI console_txt;
    [SerializeField] private string sceneName;
    public string SceneName => sceneName;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(statusEnemySO.BattleInfo == "isKilledEnemy")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "てきをたおした!\n\nゴールドゲット!\n\nマップへとぶ!   ▼";
            if(Input.GetMouseButtonDown(0))
            {
                statusEnemySO.BattleInfo = "";
                SceneManager.LoadScene(SceneName);
            }
        }else if(statusEnemySO.BattleInfo == "isKilledPlayer")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "プレイヤーがやられた!\n\nマップへとぶ!   ▼";
            if(Input.GetMouseButtonDown(0))
            {
                statusEnemySO.BattleInfo = "";
                SceneManager.LoadScene(SceneName);
            }
            
        }else if(statusEnemySO.BattleInfo == "attack")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "プレイヤーが"+statusSO.ATK.ToString()+"こうげきした!\n\n敵が"+Math.Max(0,statusEnemySO.ATK-statusSO.EQUIP)+"こうげきした!";
        }else if(statusEnemySO.BattleInfo == "heal")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "まほうのこうか はつどう!\n\nプレイヤーが 50かいふくした!";
        }else if(statusEnemySO.BattleInfo == "fire")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "まほうのこうか はつどう!\n\nプレイヤーが 50こうげきした!";
        }else if(statusEnemySO.BattleInfo == "bless")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "まほうのこうか はつどう!\n\nプレイヤーが 200こうげきした!";
        }else if(statusEnemySO.BattleInfo == "protection")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "まほうのこうか はつどう!\n\nプレイヤーが 50装備力UPした!";
        }else if(statusEnemySO.BattleInfo == "boost")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "まほうのこうか はつどう!\n\nプレイヤーが 30ATK UPした!";
        }

    }
}
