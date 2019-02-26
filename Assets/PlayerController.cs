using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour{

    Rigidbody rb;
    Animator anim;

    Transform player;
    
    int frameFlicker = 0;

    float zero = 0;

    [SerializeField]
    float speed;

    [SerializeField]
    float jumpForce;
    

    void Awake(){
        // init call
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
        player = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Start(){
        //rb.velocity = Vector3.forward * speed;
    }

    // Update is called once per frame
    void Update(){
        
        //change to screen touch

        if(frameFlicker == 30){
            rb.velocity = Vector3.forward * speed;
            frameFlicker = 0;
        }else{
            frameFlicker++;
        }

        if(Input.GetMouseButtonDown(0)){
            anim.SetTrigger("jump");
            //rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            turnLeft();
        }

    }

    void turnLeft(){

        player.Rotate(Vector3.up, -90);
        rb.velocity = Vector3.forward * 0;
        

    }

    void turnRight(){

        player.Rotate(Vector3.up, 90);

    }
}
