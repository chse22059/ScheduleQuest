using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class fightButton : MonoBehaviour
{
    public bool isKilled = false;
    [SerializeField] StatusEnemySO statusEnemySO;
    [SerializeField] StatusSO statusSO;
    [SerializeField] private string sceneName;
    public string SceneName => sceneName;
    

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
        if(statusEnemySO.HP == 0)
        {
            isKilled = true;
        }
        if(isKilled)
        {
            SceneManager.LoadScene(SceneName);
        }
    }
}
