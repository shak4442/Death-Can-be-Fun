using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Coin"){
            Score.scoreAmount ++;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Enemy"){
            Deaths.deathAmount ++;
        }
        
    }

    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }
}
