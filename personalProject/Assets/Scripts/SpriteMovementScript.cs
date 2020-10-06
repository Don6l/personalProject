using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMovementScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 0f;
    [SerializeField]
    private float jumpForce = 0f;
    [SerializeField]
    private Rigidbody2D myRigidbody = null;
    [SerializeField]
    private Collider2D myCollider = null;
    [SerializeField]
    private SpriteRenderer mySpriteRenderer = null;
    [SerializeField]
    GameMasterScript gameMasterScript;

    private bool canJump = true;
   
    
    private void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    private void FixedUpdate()
    {
        if(!gameMasterScript.isGamePaused)
        { 
            if (Input.GetKey(KeyCode.D))
            {
                myRigidbody.velocity = new Vector2(moveSpeed, myRigidbody.velocity.y);
                mySpriteRenderer.flipX = false;
            }

            if (Input.GetKey(KeyCode.A))
            {
                myRigidbody.velocity = new Vector2((moveSpeed*-1), myRigidbody.velocity.y);
                mySpriteRenderer.flipX = true;
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
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        canJump = true;
    }
}