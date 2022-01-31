using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    [SerializeField]float movementSpeed;
    // Start is called before the first frame update
    void Start()
    {
        movementSpeed = 1000f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.A)){
            rb.AddForce(-movementSpeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddForce(movementSpeed*Time.deltaTime,0,0);
        }
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(0,0,movementSpeed*Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S)){
            rb.AddForce(0,0,-movementSpeed*Time.deltaTime);
        }
    }
}
