using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel : MonoBehaviour
{
    public float jumpSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y<0)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
       
        
        if(rb!= null)
        {
            Vector2 JumpVelocity = rb.velocity;
            JumpVelocity.y = jumpSpeed;
            rb.velocity = JumpVelocity;

        }
        }
    }
}
