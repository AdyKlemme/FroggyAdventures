using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private bool levelCompleted = false;

    public static Finish instance;
    private BoxCollider2D doorColl;
    private Animator doorAnim;

    private void Awake()
    {
        if (instance == null)
            instance = this;
        doorColl = GetComponent<BoxCollider2D>();
        doorAnim = GetComponent<Animator>();
    }

    //Fix
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player" && !levelCompleted && ScoreCounter.coinAmount >= 18)
        {
            levelCompleted = true;
            Invoke("CompleteLevel", 1f);
        }
    }

    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}
