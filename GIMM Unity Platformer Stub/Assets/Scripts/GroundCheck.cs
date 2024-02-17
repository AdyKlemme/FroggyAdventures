using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    GameObject Player;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround;

    private void Start()
    {
        // Player = gameObject.transform.parent.gameObject;
        coll = GetComponent<BoxCollider2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Movement2D>().isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<Movement2D>().isGrounded = false;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround); 
        // Creates box around player like collider (center and size over collider box), 0 rotation, moves box down a tiny bit, wether it is overlapping with ground
        //
    }
}
