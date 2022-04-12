using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Como moverse

    [SerializeField] float moveSpeed;

    float vertical, horizontal;

    Rigidbody2D myRigitbody2D;

    void Start()
    {
        myRigitbody2D = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        MoveBall();
    }

    void MoveBall()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        myRigitbody2D.velocity = new Vector2(horizontal + moveSpeed, vertical + moveSpeed);
    }
}
