using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatusWindowManagerEnemy : MonoBehaviour
{
    [SerializeField] StatusEnemySO statusEnemySO;

    [SerializeField] TextMeshProUGUI enemy_hp_txt;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy_hp_txt.GetComponent<TextMeshProUGUI>().text = "HP : "+statusEnemySO.HP.ToString();
    }
}
