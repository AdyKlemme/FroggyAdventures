using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 10f;
    [SerializeField] public float runningSpeed = 20f;
    [SerializeField] public float jumpForce = 20f;
    public bool isGrounded;
    private SpriteRenderer sprite;

    public Rigidbody2D rb;// New// New
    private Animator anim;
    public float dirX = 0;// New// New
    private enum MovementState { Frog_Idle, Frog_Hop, Frog_Jump, Frog_Fall}

    private bool doubleJump; // New

    public void Start()
    {
        sprite = gameObject.GetComponent<SpriteRenderer>();// New// New
        
        rb = GetComponent<Rigidbody2D>();// New// New
        anim = GetComponent<Animator>();// New// New


    }
    private void Update()
    {

        dirX = Input.GetAxisRaw("Horizontal");// New// New
        rb.velocity = new Vector2(dirX * moveSpeed, rb.velocity.y);// New// New

        Jump();

        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        //transform.position += movement * Time.deltaTime * moveSpeed / 2;

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = runningSpeed;
        }
        else
        {
            moveSpeed = moveSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 10f;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            sprite.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            sprite.flipX = true;
        }


        UpdateAnimationUpdate();
    }

    void Jump()
    {
        //New
        if (!Input.GetButton("Jump") && isGrounded)
        {
            doubleJump = false;
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            if (isGrounded || doubleJump)// New
            {
                gameObject.GetComponent<Rigidbody2D>().velocity = (new Vector2(0f, jumpForce));

                doubleJump = !doubleJump; //New
            }
        }    
    }


    void UpdateAnimationUpdate()
    {
        MovementState state;
        
        if (rb.velocity.x > .1f)// New// New
        {
            state = MovementState.Frog_Hop;
        }
        else if (rb.velocity.x < -.1f)// New// New
        {
            state = MovementState.Frog_Hop;
        }
        else// New// New
        {
            state = MovementState.Frog_Idle;
        }

        
        if(rb.velocity.y > .1f)
        {
            state = MovementState.Frog_Jump;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.Frog_Fall;
        }

        anim.SetInteger("state", (int)state);
    }



}




/*
 * Notes:
 * 
 */

