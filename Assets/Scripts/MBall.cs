using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBall : MonoBehaviour
{
    public GameObject SBall;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     private void OnCollisionEnter2D(Collision2D collision){
        // GameObject fire = GameObject.FindGameObjectsWithTag("Fire");
        
        if(collision.gameObject.CompareTag("Fire")){
            Destroy(gameObject);
            Destroy(collision.gameObject);
            Instantiate(SBall, transform.position, SBall.transform.rotation);
            Instantiate(SBall, transform.position, SBall.transform.rotation);
        }
     }
}
