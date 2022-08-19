using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    float Movemnt = 0f;
    float Speed = 10f;
    private float Movementspeed = 8f;
    private float MaxPosition = 2.25f;
    private float MiniPosition = -2.25f;

    Rigidbody2D rb;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movemnt = Input.GetAxis("Horizontal") * Speed;
        position = transform.position;
        position.x = Mathf.Clamp(position.x, MiniPosition, MaxPosition);
        transform.position = position;
    }
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = Movemnt;
        rb.velocity = velocity;
    }
    public void TouchMovement()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float midel = Screen.width / 2;
            if (touch.position.x < midel && touch.phase == TouchPhase.Began)
            {
                LeftSite();
            }
            else if (touch.position.x > midel && touch.phase == TouchPhase.Began)
            {
                RightSite();
            }
        }
        else
        {
            velocityZero();
        }
    }
    void RightSite()
    {
        rb.velocity = new Vector2(Movementspeed, 0);
    }
    void LeftSite()
    {
        rb.velocity = new Vector2(-Movementspeed, 0);
    }
    public void velocityZero()
    {
        rb.velocity = Vector2.zero;
    }
}
