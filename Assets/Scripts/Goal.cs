using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    SpriteRenderer End;
    void Start()
    {
        End = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (GameObject.FindWithTag("Coin") != null){    
            Debug.Log("exists");
            End.color = new Color (1, 0, 0, 0.5f); 
        } 
        else {
            Debug.Log("does not exists");
            End.color = new Color (0, 1, 0, 0.5f); 

        }
    }
}
