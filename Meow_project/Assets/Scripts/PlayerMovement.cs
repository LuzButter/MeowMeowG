using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float MoveSpeed;
    public Rigidbody2D rb;
    public Vector2 moveDir;
    public Animator animator;
    public SpriteRenderer spriteRenderer;

    bool PressW;

    // Update is called once per frame
    void Update()
    {
        ProcessInpute();
    }

    void FixedUpdate()
    {
        Move();
    }

    void ProcessInpute()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDir = new Vector2(moveX, moveY).normalized;
        if (moveX == 0f && moveY == 0f)
        {
            animator.SetBool("isMoving", false);
        }
        else
        {
            animator.SetBool("isMoving", true);
        }
        if (moveDir.y == 1f)
        {
            animator.SetBool("isYwalk", true);
        }
        else
        {
            animator.SetBool("isYwalk", false);
        }
        if (moveX > 0f)
        {
            spriteRenderer.flipX = false;
        }
        else if(moveX < 0f)
        {
            spriteRenderer.flipX = true;
        }
        
    }

    void Move()
    {
        rb.velocity = new Vector2(moveDir.x*MoveSpeed*Time.fixedDeltaTime, moveDir.y*MoveSpeed*Time.fixedDeltaTime);
    }
}

   
