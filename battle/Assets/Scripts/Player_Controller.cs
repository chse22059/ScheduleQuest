using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_Controller : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private FloatingJoystick inputMove;
    float moveSpeed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

  void OnTriggerEnter2D(Collider2D col)
   {
         if (col.gameObject.tag == "back_mapSelect")//マップ画面に戻るオブジェクトに接触したらシーンの切り替え
       {
           SceneManager.LoadScene("map_select");
       }
      
   }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * inputMove.Vertical * moveSpeed * Time.deltaTime;
        this.transform.position += this.transform.right * inputMove.Horizontal * moveSpeed * Time.deltaTime;
    }
}
