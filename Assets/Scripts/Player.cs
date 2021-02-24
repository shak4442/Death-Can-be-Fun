using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector2 speed = new Vector2(10, 10);
    public Transform spawnpoint;

    void OnCollisionEnter2D(Collision2D col)
    {
        //detects collision with coin and adds score
        if (col.gameObject.tag == "Coin"){
            Score.scoreAmount ++;
            Destroy(col.gameObject);
        }

        if (col.gameObject.tag == "Enemy"){
            Deaths.deathAmount ++;
            Respawn();
        }
    }
    
    public void Respawn() 
    {
        this.transform.position = spawnpoint.position;
    }

    void Update()
    {
        //movement from inputs
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);

    }
}
