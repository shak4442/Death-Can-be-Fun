using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player"){
            Deaths.deathAmount ++;
            Destroy(col.gameObject);
        }
    }
}
