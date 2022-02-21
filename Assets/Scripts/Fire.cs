using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed = 10.0f;
    private float topBound = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > topBound) 
        {
            Destroy(gameObject); 
        }
        transform.Translate(Vector3.right * Time.deltaTime * speed);
    }
}
