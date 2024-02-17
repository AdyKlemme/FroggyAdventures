using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect_Typing : MonoBehaviour
{
    //version 2022
    Text textContainer;
    public float textSpeed;

    string textCache;

    void Start()
    {
        textContainer = this.GetComponent<Text>();

        if(textContainer == null)
        {
            Debug.LogError("TextEffect_Typing must be placed on a Text UI object");
            return;
        }

        //textSpeed = 1.1f - PlayerPrefs.GetFloat("txt");

        textCache = textContainer.text;
        textContainer.text = "";
        StartCoroutine("typeEffect");
    }

    IEnumerator typeEffect()
    {
        foreach (char c in textCache)
        {
            yield return new WaitForSeconds(textSpeed);
            textContainer.text += c;
        }
    }

}
