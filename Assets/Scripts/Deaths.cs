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
        deathText = GetComponent<Text>();
        deathAmount = 0;
    }

    void Update()
    {
        deathText.text = "Deaths = " + deathAmount;
    }
}
