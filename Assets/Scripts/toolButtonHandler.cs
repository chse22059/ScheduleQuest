using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class toolButtonHandler : MonoBehaviour
{
    [SerializeField] StatusSO statusSO;
    [SerializeField] StatusEnemySO statusEnemySO;
    [SerializeField] shopSO sso;

    public Button herb;
    public Button ironSword;
    public Button steelSword;
    public Button legendSword;
    public Button woodShield;
    public Button ironShield;
    public Button magicShield;
    public Button leatherArmor;
    public Button ironArmor;
    public Button superArmor;
    public Button recoveryPotion;
    public Button powerPotion;
    public Button magicPotion;
    public Button book;
    public Button back; 

    void Start()
    {
        back.onClick.AddListener(() => 
        {
            statusEnemySO.BattleInfo = "noChange";
            SceneManager.LoadScene(statusEnemySO.STAGE);
        });
        herb.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.HERB >= 1)
            {
                sso.HERB -= 1;
                statusSO.HP += 20;
                statusEnemySO.BattleInfo = "herb";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        ironSword.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.IRONSWORD >= 1)
            {
                sso.IRONSWORD -= 1;
                statusEnemySO.ATKPlayerTemp += 10;
                statusEnemySO.BattleInfo = "ironSword";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        steelSword.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.STEELSWORD >= 1)
            {
                sso.STEELSWORD -= 1;
                statusEnemySO.ATKPlayerTemp += 30;
                statusEnemySO.BattleInfo = "steelSword";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        legendSword.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.LEGENDSWORD >= 1)
            {
                sso.LEGENDSWORD -= 1;
                statusEnemySO.ATKPlayerTemp += 50;
                statusEnemySO.BattleInfo = "legendSword";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        woodShield.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.WOODSHIELD >= 1)
            {
                sso.WOODSHIELD -= 1;
                statusSO.EQUIP += 10;
                statusEnemySO.BattleInfo = "woodShield";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
            
        });
        ironShield.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.IRONSHIELD >= 1)
            {
                sso.IRONSHIELD -= 1;
                statusSO.EQUIP += 25;
                statusEnemySO.BattleInfo = "ironShield";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        magicShield.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.MAGICSHIELD >= 1)
            {
                sso.MAGICSHIELD -= 1;
                statusSO.EQUIP += 40;
                statusEnemySO.BattleInfo = "magicShield";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        leatherArmor.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.LEATHERARMOR >= 1)
            {
                sso.LEATHERARMOR -= 1;
                statusEnemySO.EquipPlayerTemp += 10;
                statusEnemySO.BattleInfo = "leatherArmor";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        ironArmor.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.IRONARMOR >= 1)
            {
                sso.IRONARMOR -= 1;
                statusEnemySO.EquipPlayerTemp += 30;
                statusEnemySO.BattleInfo = "ironArmor";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        superArmor.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.SUPERARMOR >= 1)
            {
                sso.SUPERARMOR -= 1;
                statusEnemySO.EquipPlayerTemp += 50;
                statusEnemySO.BattleInfo = "superArmor";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        recoveryPotion.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.RECOVERYPOTION >= 1)
            {
                sso.RECOVERYPOTION -= 1;
                statusSO.HP += 50;
                statusEnemySO.BattleInfo = "recoveryPotion";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
            
        });
        powerPotion.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.POWERPOTION >= 1)
            {
                sso.POWERPOTION -= 1;
                statusSO.ATK += 30;
                statusEnemySO.BattleInfo = "powerPotion";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
            
        });
        magicPotion.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.MAGICPOTION >= 1)
            {
                sso.MAGICPOTION -= 1;
                statusSO.MP += 30;
                statusEnemySO.BattleInfo = "magicPotion";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
        book.onClick.AddListener(() => 
        {
            statusSO.LoadStatus();
            sso.LoadStatus();
            if(sso.BOOK >= 1)
            {
                sso.BOOK -= 1;
                statusSO.HP += 100;
                statusSO.MP += 100;
                statusSO.ATK += 50;
                statusEnemySO.BattleInfo = "book";
                statusSO.SaveStatus();
                sso.SaveStatus();
                SceneManager.LoadScene(statusEnemySO.STAGE);
            }
        });
    }
}



