using UnityEngine;
using UnityEngine.UI;

public class fightButton : MonoBehaviour
{

    [SerializeField] StatusEnemy statusEnemy;
    [SerializeField] StatusSO statusSO;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void push()
    {
        statusEnemy.HP -= statusSO.ATK;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
