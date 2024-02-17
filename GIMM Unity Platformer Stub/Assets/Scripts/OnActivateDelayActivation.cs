using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnActivateDelayActivation : MonoBehaviour
{
    public GameObject target;
    public int delayInSeconds = 1; //default delay is 1s

    void Start()
    {
        // catch invalid setup and log error
        if (target == null)
        {
            Debug.LogError("Must set a target for " + this + " on " + gameObject);
            return;
        }
        StartCoroutine("Delay");
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayInSeconds);
        if (target.activeSelf == false) target.SetActive(true);
    }
}
