using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float horizontalInput;


   //Health variable
    int health = 3;


    //Volume variables
    public AudioClip shoot;
    private AudioSource playerAudio;
    //Animation Variables
    private Rigidbody2D rb;
    private Animator anim;
    private int direction = 1;
    public float KickBoardMovePower = 15f;
    // Start is called before the first frame update
    void Start()
    {
        //Animation
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //Sound
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 moveVelocity = Vector3.zero;
        horizontalInput =  Input.GetAxis("Horizontal");
        if (Input.GetAxisRaw("Horizontal") < 0){
                direction = -1;
                moveVelocity = Vector3.left;

               transform.localScale = new Vector2(direction, 1);
        }
        if (Input.GetAxisRaw("Horizontal") > 0){
                direction = 1;
                moveVelocity = Vector3.right;

                transform.localScale = new Vector2(direction, 1);
        }
         transform.position += moveVelocity * KickBoardMovePower * Time.deltaTime;


        //transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        if(horizontalInput!=0){
            anim.SetBool("isRun", true);
        }
        else{
            anim.SetBool("isRun", false);
        }
        
        if (Input.GetKeyDown(KeyCode.Space)){
            playerAudio.PlayOneShot(shoot, 1.0f);
        // Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            
        }
    }


        private void OnCollisionEnter2D(Collision2D collision){
        // GameObject fire = GameObject.FindGameObjectsWithTag("Fire");
        
        if(collision.gameObject.CompareTag("BallT")){
            --health;
            if(health<1)
            Destroy(gameObject);
        }

    }


    
}
