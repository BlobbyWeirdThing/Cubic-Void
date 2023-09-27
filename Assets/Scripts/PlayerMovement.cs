using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float JumpingPower = 16f;
    private float shrunkJumpingPower = 10f;
    private float bigJump = 28f;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform GroundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private LayerMask shrinkLayer;
    [SerializeField] private LayerMask largeLayer;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            rb.velocity = new Vector2(rb.velocity.x, JumpingPower);
        }

        if (Input.GetKeyDown(KeyCode.Space) && IsShrunk())
        {
            rb.velocity = new Vector2(rb.velocity.x, shrunkJumpingPower);
        }


        if (Input.GetKeyDown(KeyCode.Space) && IsBig())
        {
            rb.velocity = new Vector2(rb.velocity.x, bigJump);
        }

        if (Input.GetKeyUp(KeyCode.Space) && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, 0.2f, groundLayer);
    }

    private bool IsShrunk()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, 0.5f, shrinkLayer);
    }

    private bool IsBig()
    {
        return Physics2D.OverlapCircle(GroundCheck.position, 0.4f, largeLayer);
    }
}
