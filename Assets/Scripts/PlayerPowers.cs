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
            PlayerMovement pm = player.GetComponent<PlayerMovement>();
            if(Time.time>=pm.cd1Counter)
            {
                Rigidbody scoreBall = player.GetComponent<Rigidbody>();
                Debug.Log(scoreBall.velocity.ToString());
                scoreBall.velocity = scoreBall.velocity*(16/10);            //Increases velocity by 60%
                pm.cd1Counter = pm.cd1Counter + 10;                      //Cooldown of 10 secs
                Debug.Log(Time.time);
            }
        }
        //Debug.Log(player.GetComponent<Rigidbody>().angularVelocity);

    }

    public void power2(GameObject player, int charType)
    {
        //Debug.Log(player);
        if(charType == 3)
        {
            player.GetComponent<Rigidbody>().angularVelocity = player.GetComponent<Rigidbody>().angularVelocity + new Vector3(0,(float).05,0);
        }
        else if(charType == 4)
        {   
            PlayerMovement pm = player.GetComponent<PlayerMovement>(); 
            if(Time.time>=pm.cd2Counter)
            {
                Rigidbody scoreBall = player.GetComponent<Rigidbody>();
                Debug.Log(scoreBall.velocity.ToString());
                scoreBall.velocity = scoreBall.velocity*0;              //Stops velocity
                pm.cd2Counter = pm.cd2Counter + 7;                      //Cooldown of 7 secs
                Debug.Log(Time.time);
            }
        }
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
