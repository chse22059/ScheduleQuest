using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Display_Console : MonoBehaviour
{
    [SerializeField] StatusSO statusSO;
    [SerializeField] StatusEnemySO statusEnemySO;
    [SerializeField] TextMeshProUGUI console_txt;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }


    // Update is called once per frame
    void Update()
    {
        if(statusEnemySO.HP <= 0)
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = "てきをたおした！";
        }else if(statusEnemySO.BattleInfo == "attack")
        {
            console_txt.GetComponent<TextMeshProUGUI>().text = statusSO.ATK.ToString()+"こうげきした！";
        }

    }
}
