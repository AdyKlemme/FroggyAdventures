using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class PlayerTeleport : MonoBehaviour
//{
//    public GameObject currentTeleporter;


//    void Start()
//    {
//        currentTeleporter = GetComponent<Teleporter>();
//    }

    
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.E))
//        {
//            if (currentTeleporter != null)
//            {
//               transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
//            }
//        }
//    }

//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        if (collision.CompareTag("Teleporter"))
//        {
//            currentTeleporter = collision.gameObject;
//        }
//    }

//    private void OnTriggerExit2D(Collider2D collision)
//    {
//        if (collision.CompareTag("Teleporter"))
//        {
//            if (collision.gameObject == currentTeleporter)
//            {
//                currentTeleporter = null;
//            }
//        }
//    }
//}
