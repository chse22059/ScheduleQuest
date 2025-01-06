using UnityEngine;

public class MapManager : MonoBehaviour
{
    public GameObject player;
    public GameObject bossObject;
    public GameObject MidbossObject;

    void Start()
    {
        if (player != null)
        {  
        
            // 保存された位置を取得してプレイヤーを移動
            Vector2 savedPosition = GameManager.Instance.playerPosition;
            // 保存された位置がある場合に復元
            if (savedPosition != Vector2.zero)
            {
                player.transform.position = savedPosition;
            }
        }
        if(bossObject != null) {
            if(GameManager.Instance.isBossDefeated) {
                Destroy(bossObject);
            }
        }
        if(MidbossObject != null) {
            if(GameManager.Instance.isMidBossDefeated){
                Destroy(MidbossObject);
            }
        }
    }
}
