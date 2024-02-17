using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text text;

   // public string Level = "Spawn";

    public static int coinAmount;

    //public Dictionary<string, int> playerTitle = new Dictionary<string, int>()
    //{
    //    {"Spawn", 0},

    //};
    
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
        text.text = "Mushies: " + coinAmount.ToString(); //  + "\nLevel: " + Level
    }


}
