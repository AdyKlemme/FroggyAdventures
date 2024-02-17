using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{

    private Animator anim;
    //private Rigidbody2D rb;
    public Transform respawnPoint;
    public GameObject player;

    void Start()
    {
        anim = GetComponent<Animator>();
        //rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            Die();
        }
    }

    private void Die()
    {
        player.transform.position = respawnPoint.position;
    }

    private void RestartLevel()
    {
        player.transform.position = respawnPoint.position;
    }

}
