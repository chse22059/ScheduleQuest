using UnityEngine;
using UnityEngine.UI;
using System;


public class fightButton : MonoBehaviour
{
    [SerializeField] StatusEnemySO statusEnemySO;
    [SerializeField] StatusSO statusSO;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()
    {
        statusEnemySO.BattleInfo = "attack";
        statusEnemySO.HP -= statusSO.ATK+statusEnemySO.ATKPlayerTemp;
        
        statusSO.HP -= Math.Max(0,statusEnemySO.ATK-statusSO.EQUIP-statusEnemySO.EquipPlayerTemp);

        statusEnemySO.ATKPlayerTemp = 0;
        statusEnemySO.EquipPlayerTemp = 0;
        if(statusEnemySO.HP < 0)
        {
            statusEnemySO.HP = 0;
        }
        if(statusSO.HP < 0)
        {
            statusSO.HP = 0;
        }
        

        if(statusSO.HP <= 0)
        {
            statusEnemySO.BattleInfo = "isKilledPlayer";
        }
        if(statusEnemySO.HP <= 0)
        {
            statusEnemySO.BattleInfo = "isKilledEnemy";
            statusEnemySO.KilledCount += 1;
            statusSO.GOLD += 1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
