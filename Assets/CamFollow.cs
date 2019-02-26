using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour{
    // Start is called before the first frame update
    
    [SerializeField]
    Transform player;

    Vector3 offset;

    [SerializeField]
    float smoothRate;

    void Start()
    {
        offset = player.position - transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate(){

        Vector3 currPos = transform.position;
        Vector3 newPos = player.position - offset;
        
        transform.position = Vector3.Lerp(currPos, newPos, smoothRate);

    }
}
