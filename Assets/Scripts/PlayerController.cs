﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
        rb.velocity = Vector3.forward * speed;
    }

    // Update is called once per frame
    void Update(){
        
        //change to screen touch

        if(frameFlicker == 60){
            rb.velocity = Vector3.forward * speed;
            frameFlicker = 0;
        }else{
            frameFlicker++;
        }

        //rb.AddForce(Vector3.forward * moveSpeed);

        if(Input.GetMouseButtonDown(0)){
            
            float x = Input.mousePosition.x;
            float y = Input.mousePosition.y;

            if(x >= 45 && x <= 135){
                if(y >= 55 && y <= 145){
                    //print("Left key");
                    rb.AddForce(Vector3.left * moveSpeed);
                }
            }
            else if(x >= 340 && x <= 435){
                if(y >= 55 && y <= 145){
                    //print("Right key");
                    rb.AddForce(Vector3.right * moveSpeed);
                }
            }
            else {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                anim.SetTrigger("jump");
            }

            /* string a;
            a = string.Format("x - {0}, y - {1}" , x, y);
            print(a);*/
        }

        if (Input.GetKeyUp(KeyCode.A)){
            //controller.Move((Vector3.left * moveSpeed) * Time.deltaTime);
            rb.AddForce(Vector3.left * moveSpeed);
        }

        if (Input.GetKeyUp(KeyCode.D)){
            //controller.Move((Vector3.right * jumpForce));
            rb.AddForce(Vector3.right * moveSpeed);
        }

        
    }

    void TestBtnPress(){
        print("nagdi bai");
    }
    

}
