using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_SceneManege : MonoBehaviour
{
    public float distanceThreshold = 3f;//エンカウントの抽選を行う距離
    public float encounterProbability = 0.3f;//エンカウント発生率
    

    private Vector2 previousPosition;
    private float distanceMoved = 0f; //移動距離の累積
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

    void TryEncounter() {
        if(Random.value <= encounterProbability) {
            Debug.Log("encount");
            //SceneManager
        } else {
            Debug.Log("through");
        }
    }

    void OnTriggerEnter2D(Collider2D col) {
        if(col.gameObject.tag == "back_mapSelect") {
          SceneManager.LoadScene("map_select",LoadSceneMode.Single);
        }
    }
}
