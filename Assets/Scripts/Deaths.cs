using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deaths : MonoBehaviour
{
    public static int deathAmount;
    public Text deathText;

    void Start()
    {
        //get text component from canvas
        deathText = GetComponent<Text>();
        deathAmount = 0;
    }

    void Update()
    {
        //updates text to add deaths
        deathText.text = "Deaths = " + deathAmount;
    }
}
