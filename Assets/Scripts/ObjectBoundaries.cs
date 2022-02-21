using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectBoundaries : MonoBehaviour
{
    private float xRange = 15; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                //keep player to bounds
        if(transform.position.x <-xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
    }
}
