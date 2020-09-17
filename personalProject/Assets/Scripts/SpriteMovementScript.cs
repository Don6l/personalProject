using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovementScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    [SerializeField]
    private float jumpForce;
    [SerializeField]
    private Rigidbody2D myRigidbody;
    [SerializeField]
    private Collider2D myCollider;

    private bool canJump = true;

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
        }

        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.velocity = new Vector2((moveSpeed*-1), myRigidbody.velocity.y);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            if (canJump)
            {
                myRigidbody.velocity = new Vector2(myRigidbody.velocity.x, jumpForce);
                canJump = false;
            }      
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}