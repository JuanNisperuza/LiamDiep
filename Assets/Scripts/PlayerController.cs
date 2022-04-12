using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 12;
    float runningSpeed = 4;
    Rigidbody2D rigidBody;
    public LayerMask groundMask;
    private const string STATE_ON_THE_GROUND = "isOnTheGround";
    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (gameObject.name == "Player1")
        {
            MovePlayerOne();
        }
        else
        {
            MovePlayerTwo();
        }
    }

    public void MovePlayerOne()
    {
        if (Input.GetKeyDown(KeyCode.W) && isTouchingTheGround())
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            rigidBody.velocity = new Vector2(-runningSpeed, rigidBody.velocity.y);
        }
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
        }
    }

    public void MovePlayerTwo()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow) && isTouchingTheGround())
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            rigidBody.velocity = new Vector2(-runningSpeed, rigidBody.velocity.y);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().flipX = false;
            rigidBody.velocity = new Vector2(runningSpeed, rigidBody.velocity.y);
        }
    }


    public void Jump()
    {
        rigidBody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }

    public bool isTouchingTheGround()
    {
        if (Physics2D.Raycast(this.transform.position, Vector2.down, 2.0f, groundMask))
        {

            return true;
        }
        else
        {
            return false;
        }
    }
}

