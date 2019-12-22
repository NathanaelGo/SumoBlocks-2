using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rbmain;
    
    public float MaxSpeed = 200f;
    public float MaxTorque = 1f;
    public string forward = "w";
    public string left = "a";
    public string right = "d";
    public string backward = "s";



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(right))
        {
            rbmain.AddForce(MaxSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(left))
        {
            rbmain.AddForce(-MaxSpeed * Time.deltaTime, 0, 0);
        }
        if(Input.GetKey(forward))
        {
            rbmain.AddForce(0, 0, MaxSpeed* Time.deltaTime);
        }
        if (Input.GetKey(backward))
        {
            rbmain.AddForce(0, 0, -MaxSpeed * Time.deltaTime);
        }
    }
}
