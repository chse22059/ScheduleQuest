using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_SceneManege : MonoBehaviour
{
    public float distanceThreshold = 3f;//エンカウントの抽選を行う距離
    public float encounterProbability = 0.3f;//エンカウント発生率
    private Vector2 previousPosition;
    private float distanceMoved = 0f; //移動距離の累積
    [SerializeField]
    private string battleScene;
    public string BSceneName => battleScene;

    public GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
      previousPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentPosition = transform.position;
        distanceMoved += Vector2.Distance(currentPosition,previousPosition);
        previousPosition = currentPosition;
        if(distanceMoved >= distanceThreshold) {
            distanceMoved =0f;
            TryEncounter();
        }
    }

    public void TryEncounter() {
        if(Random.value <= encounterProbability && player != null) {
            Player_MoveController.canMove = false;
            GameManager.Instance.SavePlayerPosition(player.transform.position);
            SceneManager.LoadScene(BSceneName);
            //SceneManager
        } else {
            Debug.Log("through");
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "IntPosition") {
            GameManager.Instance.SavePlayerPosition(player.transform.position);
        }
        if(col.gameObject.tag == "back_mapSelect") {
            SceneManager.LoadScene("map_select");
        }
        if(col.gameObject.tag == "Boss") {
            GameManager.Instance.SavePlayerPosition(player.transform.position);
            SceneManager.LoadScene("Boss_Battle(kari)");
        } else if(col.gameObject.tag == "MidBoss") {
            GameManager.Instance.SavePlayerPosition(player.transform.position);
            SceneManager.LoadScene("MidBoss_Battle(kari)");
        }
    }
}
