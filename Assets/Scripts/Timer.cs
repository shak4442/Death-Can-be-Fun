using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float time = 0f;
    public Text timeText;
    
    void Start()
    {
        timeText = GetComponent<Text>();
    }

    void Update()
    {
        time += Time.deltaTime;
        timeText.text = "Timer = " + Mathf.Round(time * 100) / 100.0;

    }
}
