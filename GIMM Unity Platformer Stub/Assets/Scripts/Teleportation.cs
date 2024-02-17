using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    [SerializeField] private Transform destination;


    public Transform GetDestination()
    {
        return destination;
    }

    public bool isPortal1;
    public bool isPortal2;
    public bool isPortal3;
    public bool isPortal4;
    public bool isPortal5;
    public bool isPortal6;

    public float distance = 0.5f;

    void Update()
    {
        if (isPortal1 == true)
        {
            destination = GameObject.FindGameObjectWithTag("Portal2").GetComponent<Transform>();
        }
        else if (isPortal2 == true)
        {
            destination = GameObject.FindGameObjectWithTag("Portal1").GetComponent<Transform>();
        }

        else if (isPortal3 == true)
        {
            destination = GameObject.FindGameObjectWithTag("Portal4").GetComponent<Transform>();
        }
        else if (isPortal4 == true)
        {
            destination = GameObject.FindGameObjectWithTag("Portal3").GetComponent<Transform>();
        }

        else if (isPortal5 == true)
        {
            destination = GameObject.FindGameObjectWithTag("Portal6").GetComponent<Transform>();
        }
        else if (isPortal6 == true)
        {
            destination = GameObject.FindGameObjectWithTag("Portal5").GetComponent<Transform>();
        }
    }


    void OnTriggerEnter2D(Collider2D collision)
    {

        if (Vector2.Distance(transform.position, collision.transform.position) > distance)
        {
            collision.transform.position = new Vector2(destination.position.x + 1, destination.position.y - 2f);
        }

    }

}
