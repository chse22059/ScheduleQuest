using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
 * キャラの座標を変更するController
 */
public class MoveController : MonoBehaviour
{
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
    }
    void Update()
    {
        // x,ｙの入力値を得る
        inputAxis.x = joystick.Horizontal;
        inputAxis.y = joystick.Vertical;
    }
    private void FixedUpdate()
    {
        // 速度を代入する
        rigidBody.linearVelocity = inputAxis.normalized * SPEED;
    }
}