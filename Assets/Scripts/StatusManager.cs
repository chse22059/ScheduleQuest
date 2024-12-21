using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public int[] statusPlayerValue = new int[5];//ゴールド、mp、攻撃力、体力、装備
    public int[] statusEnemyValue = new int[2];//攻撃力、体力

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0;i < statusPlayerValue.length; i++)
        {
            load_mode();
        }
    }

    void load_mode()
    {
        for(int i = 0;i < statusPlayerValue.length; i++)
        {
            statusPlayerValue[i] = PlayerPrefs.GetInt("statusPlayerValue"+i);
        }
        
    }

    void save_mode()
    {
        for(int i = 0;i < statusPlayerValue.length; i++)
        {
            PlayerPrefs.SetInt("statusPlayerValue"+i, statusPlayerValue[i]);
            PlayerPrefs.Save();
        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
