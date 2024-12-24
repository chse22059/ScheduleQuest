using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public bool isBossDefeated =false;
    public bool isMidBossDefeated=false;
    public Vector2 playerPosition; // プレイヤーの位置を保存

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // シーン間で保持
        }
        else
        {
            Destroy(gameObject);
        }
    }
    

    public void SavePlayerPosition(Vector2 position)
    {
        playerPosition = position;
    }
}
