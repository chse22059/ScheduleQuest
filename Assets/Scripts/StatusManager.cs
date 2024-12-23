using UnityEngine;

public class StatusManager : MonoBehaviour
{
    public int[] statusPlayerValue = new int[5];//ゴールド、mp、攻撃力、体力、装備
    public int[] statusEnemyValue = new int[2];//攻撃力、体力

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int i = 0;i < statusPlayerValue.Length; i++)
        {
            load_mode();
        }
    }

    void load_mode()//以前保存したステータスの代入
    {
        for(int i = 0;i < statusPlayerValue.Length; i++)
        {
            statusPlayerValue[i] = PlayerPrefs.GetInt("statusPlayerValue"+i);
        }
        
    }

    void save_mode()//ステータスの保存処理
    {
        for(int i = 0;i < statusPlayerValue.Length; i++)
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
