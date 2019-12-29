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
    public string pow1 = "e";
    public string pow2 = "q";


    public void setControl(string f,string l,string r,string b)
    {
        forward = f;
        left = l;
        right = r;
        backward = b;
    }
    
    public void setControl(string control)
    {
        string[] controls = control.Split(' ');
        forward = controls[0];
        left = controls[1];
        right = controls[2];
        backward = controls[3];
        pow1 = controls[4];
        pow2 = controls[5];
    }


    public void testoo()
    {
        Debug.Log("IT WORKS EEEEHEE HEE");
        //Test To make sure this commit works
    }

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
