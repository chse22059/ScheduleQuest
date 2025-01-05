using UnityEngine;

public class MonsterSelect : MonoBehaviour
{
    [SerializeField] StatusEnemySO statusEnemySO;
    public SpriteRenderer spriteRenderer; 
    public Sprite[] sprites;    
    private int[] enemyHPValues = {100, 200, 200, 500, 500, 500, 1000, 1000, 2000, 5000};
    private int[] enemyATKValues = {100, 100, 200, 200, 500, 500, 500, 1000, 2000, 3000};   
    private int randStatusId;   

    void Start()
    {   
        if(statusEnemySO.BattleInfo == ""){
            // ランダムなインデックスを生成
            statusEnemySO.MonsterId = Random.Range(0, sprites.Length);
            randStatusId = Random.Range(0, enemyHPValues.Length);
            statusEnemySO.HP = enemyHPValues[randStatusId];
            statusEnemySO.ATK = enemyATKValues[randStatusId];
            statusEnemySO.BattleInfo = "gamePlaying";
        }
        if (sprites.Length > 0 && spriteRenderer != null)
        {
            // 選択したスプライトを登録
            spriteRenderer.sprite = sprites[statusEnemySO.MonsterId];
            
        }
    }
}
