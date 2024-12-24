using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/**
 * キャラの座標を変更するController
 */
public class Player_MoveController : MonoBehaviour
{   
    
    public static bool canMove=true;
    [SerializeField]
    float SPEED = 2.0f;
    private Rigidbody2D rigidBody;
    private Vector2 inputAxis;
    [SerializeField]
    public FixedJoystick joystick;

    void Start()
    {   
        // オブジェクトに設定しているRigidbody2Dの参照を取得する
        this.rigidBody = GetComponent<Rigidbody2D>();
        canMove = true;
    }
    void Update()
    {   
        // x,ｙの入力値を得る
        if(canMove == true){
            inputAxis.x = joystick.Horizontal;
            inputAxis.y = joystick.Vertical;
        } else {
            inputAxis.x = 0;
            inputAxis.y = 0;
        }
    }
    private void FixedUpdate()
    {
        // 速度を代入する
        rigidBody.linearVelocity = inputAxis.normalized * SPEED;
    }
}