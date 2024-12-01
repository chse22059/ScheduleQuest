using UnityEngine;

public class Player : MonoBehaviour
{
    
    private Rigidbody2D rb;
    private FloatingJoystick inputMove;
    float moveSpeed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += this.transform.forward * inputMove.Vertical * moveSpeed * Time.deltaTime;
        this.transform.position += this.transform.right * inputMove.Horizontal * moveSpeed * Time.deltaTime;
    }
}
