using UnityEngine;
using UnityEngine.UI;


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
        statusEnemySO.HP -= statusSO.ATK;
        
        statusSO.HP -= statusEnemySO.ATK;
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
