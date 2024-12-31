using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class magicButtonHandler : MonoBehaviour
{
    [SerializeField] StatusSO statusSO;
    [SerializeField] StatusEnemySO statusEnemySO;

    public Button heal;
    public Button fire;
    public Button bless;
    public Button protection;
    public Button boost;
    public Button back; 

    void Start()
    {
        back.onClick.AddListener(() => 
        {
            SceneManager.LoadScene(statusEnemySO.STAGE);
        });

        heal.onClick.AddListener(() => 
        {
            if(statusSO.MP >= 10)
            {
                statusSO.MP -= 10;
                statusSO.HP += 50;
                statusEnemySO.BattleInfo = "heal";
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });

        fire.onClick.AddListener(() => 
        {
            if(statusSO.MP >= 5)
            {
                statusSO.MP -= 5;
                statusEnemySO.HP -= 50;
                statusEnemySO.BattleInfo = "fire";
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });

        bless.onClick.AddListener(() => 
        {
            if(statusSO.MP >= 30)
            {
                statusSO.MP -= 30;
                statusEnemySO.HP -= 200;
                statusEnemySO.BattleInfo = "bless";
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });

        protection.onClick.AddListener(() => 
        {
            if(statusSO.MP >= 10)
            {
                statusSO.MP -= 10;
                statusSO.EQUIP += 50;
                statusEnemySO.BattleInfo = "protection";
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });

        boost.onClick.AddListener(() => 
        {
            if(statusSO.MP >= 20)
            {
                statusSO.MP -= 20;
                statusSO.ATK += 30;
                statusEnemySO.BattleInfo = "boost";
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
    }
}



