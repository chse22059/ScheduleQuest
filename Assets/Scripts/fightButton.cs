using UnityEngine;
using UnityEngine.UI;
using System;

public class fightButton : MonoBehaviour
{
    [SerializeField] StatusEnemySO statusEnemySO;
    [SerializeField] StatusSO statusSO;
    private int[] goldValues = {50, 50, 50, 100, 100, 200, 200, 500, 500, 1000};
    private int rand;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(push);
    }

    void push()
    {
        statusSO.LoadStatus();
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
            getReward();
        }
        statusSO.SaveStatus();
    }
    public void getReward(){
        statusEnemySO.KilledCount += 1;
        rand = UnityEngine.Random.Range(0, goldValues.Length);
        statusSO.GOLD += goldValues[rand];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
