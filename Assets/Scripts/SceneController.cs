using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
   public int index ;

   void OnTriggerEnter2D(Collider2D other)
    {
        if (GameObject.FindWithTag("Coin") == null)
        {
            Debug.Log("exists");
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene(index);
            };
        }
       
    }
}
