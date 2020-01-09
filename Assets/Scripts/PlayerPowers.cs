using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPowers : MonoBehaviour
{

    public void power1(GameObject player, int charType)
    {
        //Debug.Log(charType);
        if(charType == 3)
        {
            player.GetComponent<Rigidbody>().angularVelocity = player.GetComponent<Rigidbody>().angularVelocity + new Vector3(0,(float)-.05,0);
        }
        else if(charType == 4)
        {
            Rigidbody scoreBall = player.GetComponent<Rigidbody>();
            Debug.Log(scoreBall.velocity.ToString());
            scoreBall.velocity = scoreBall.velocity*3/2;
            
        }
        //Debug.Log(player.GetComponent<Rigidbody>().angularVelocity);

    }

    public void power2(GameObject player, int charType)
    {
        //Debug.Log(player);
        if(charType == 3)
            player.GetComponent<Rigidbody>().angularVelocity = player.GetComponent<Rigidbody>().angularVelocity + new Vector3(0,(float).05,0);

        //Debug.Log(player.GetComponent<Rigidbody>().angularVelocity);
        
        //player.GetComponent<Rigidbody>().AddTorque(transform.up * torque * turn);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
