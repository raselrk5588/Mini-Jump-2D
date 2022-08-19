using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float JumpSpeed = 12f;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Rigidbody2D rb = collisionInfo.collider.GetComponent<Rigidbody2D>();
        if (rb != null)
        {
            Vector2 velocity = rb.velocity;
            velocity.y = JumpSpeed;
            rb.velocity = velocity;
        }
    }
}
