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
        }else if(statusEnemySO.BattleInfo =="gamePlaying")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "";
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
        }else if(statusEnemySO.BattleInfo == "herb")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 20かいふくした!";
        }else if(statusEnemySO.BattleInfo == "ironSword")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nこうげきのダメージを+10する!";
        }else if(statusEnemySO.BattleInfo == "steelSword")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nこうげきのダメージを+30する!";
        }else if(statusEnemySO.BattleInfo == "legendSword")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nこうげきのダメージを+50する!";
        }else if(statusEnemySO.BattleInfo == "woodShield")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 10装備力UPした!";
        }else if(statusEnemySO.BattleInfo == "ironShield")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 25装備力UPした!";
        }else if(statusEnemySO.BattleInfo == "magicShield")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 40装備力UPした!";
        }else if(statusEnemySO.BattleInfo == "leatherArmor")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\n敵のこうげきを-10する!";
        }else if(statusEnemySO.BattleInfo == "ironArmor")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\n敵のこうげきを-30する!";
        }else if(statusEnemySO.BattleInfo == "superArmor")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\n敵のこうげきを-50する!";
        }else if(statusEnemySO.BattleInfo == "recoveryPotion")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 50かいふくした!";
        }else if(statusEnemySO.BattleInfo == "powerPotion")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 30ATK UPした!";
        }else if(statusEnemySO.BattleInfo == "magicPotion")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 30MP UPした!";
        }else if(statusEnemySO.BattleInfo == "book")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "どうぐのこうか はつどう!\n\nプレイヤーが 50ATK UPした!\nプレイヤーが 100HP UPした!\nプレイヤーが 100MP UPした!\n";
        }

    }
}
