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
        statusEnemySO.HP -= statusSO.ATK;
        if(statusEnemySO.HP < 0)
        {
            statusEnemySO.HP = 0;
        }
        statusEnemySO.BattleInfo = "attack";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
