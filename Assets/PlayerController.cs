using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    Rigidbody rb;
    Animator anim;
    Vector3 moveVector;
    CharacterController controller;
    
    int frameFlicker = 0;
    float zero = 0;

    [SerializeField]
    float speed;
    [SerializeField]
    float moveSpeed;
    [SerializeField]
    float jumpForce;
    

    void Awake(){
        // init call
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        controller = GetComponent<CharacterController> ();
    }
    // Start is called before the first frame update
    void Start(){
        //rb.velocity = Vector3.forward * speed;
    }

    // Update is called once per frame
    void Update(){
        
        //change to screen touch

        /* if(frameFlicker == 60){
            rb.velocity = Vector3.forward * speed;
            frameFlicker = 0;
        }else{
            frameFlicker++;
        }*/

        rb.AddForce(Vector3.forward * moveSpeed);

        if(Input.GetMouseButtonDown(0)){
            anim.SetTrigger("jump");
            //controller.Move((Vector3.up * jumpForce) * Time.deltaTime);
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.A)){
            //moveRight();
            rb.AddForce(Vector3.left * moveSpeed);
        }

        if (Input.GetKeyDown(KeyCode.D)){
            //moveRight();
            rb.AddForce(Vector3.right * moveSpeed);
        }

        
    }

}
