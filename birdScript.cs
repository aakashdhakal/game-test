using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float flapStrength;
    public LogicScript logic;
    bool BirdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && BirdIsAlive)
        {
            myrigidbody.velocity = Vector2.up *5;
        }

        if(transform.position.y < -8 || transform.position.y >8)
        {
            if (logic.isGameOver == false)
            {
                logic.GameOver();
                BirdIsAlive = false;
            }
        }
  
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
     if(logic.isGameOver == false)
        {
            logic.GameOver();
            BirdIsAlive = false;
        }
       
    }
}
