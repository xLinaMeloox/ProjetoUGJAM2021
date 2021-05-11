using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public   Rigidbody2D rb;
    public float moveSpeed = 5;
    Vector2 moveDirection;

    void Update()
    {
        //rb = GetComponent<Rigidbody2D>();
        ProcessInputs();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();

    }


    void ProcessInputs()
    {

        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        moveDirection = new Vector2(moveX, moveY).normalized;

    }
    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
