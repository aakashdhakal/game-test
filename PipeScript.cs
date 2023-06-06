using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
   
{
    public float MoveSpeed = 0;
    public float DeadSpace = -14;
    public LogicScript LogicScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += MoveSpeed * Time.deltaTime * Vector3.left; 

        if(transform.position.x < DeadSpace)
        {
            Destroy(gameObject);
        }
    }
}
