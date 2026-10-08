using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D fnn;
    public float speed = 5f;
    float movement;
    float jump = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fnn = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D)){
            movement = speed;
        } else if (Input.GetKey(KeyCode.A)){
            movement = -speed;
        } else {
            movement = 0f;
        }
        fnn.linearVelocityX = movement;
        if (Input.GetKey(KeyCode.Space)) {
            fnn.linearVelocity = new Vector2(movement, jump);
        }
    }
}
