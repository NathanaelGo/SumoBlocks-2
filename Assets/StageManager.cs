using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("CharSelect Values")]
    public int stageNumber;
    public int playerCount;
    public int p1Char;
    public int p2Char;
    public int p3Char;
    public int p4Char;

    [Header("Player Models")]
    public GameObject[] chars;
    public GameObject[] p =  new GameObject[5];         //Player Chars                  Note Slot Zero is unused
    
    [Header("Player Materials")]
    public Material p1Mat;
    public Material p2Mat;
    public Material p3Mat;
    public Material p4Mat;
     

    //Script holders for player Movement
    private PlayerMovement[] pm = new PlayerMovement[5];  //Player movement scripts     Note Slot Zero is unused
    


    void Start()
    {
        //Pulling Information from the Player pref void
        stageNumber = PlayerPrefs.GetInt("stageNumber", 0);
        playerCount = PlayerPrefs.GetInt("playerCount", 0);

        p1Char = PlayerPrefs.GetInt("p1Char", 0);
        p2Char = PlayerPrefs.GetInt("p2Char", 0);
        p3Char = PlayerPrefs.GetInt("p3Char", 0);
        p4Char = PlayerPrefs.GetInt("p4Char", 0);


        if(playerCount>=1)
        {
            p[1] = Instantiate(chars[p1Char], new Vector3(5, 1, 5), Quaternion.identity);
            pm[1] = p[1].GetComponent<PlayerMovement>();
            pm[1].setControl("w","a","d","s");
            p[1].GetComponent<Renderer>().material = p1Mat;
        }
        if(playerCount>=2)
        {
            p[2] = Instantiate(chars[p2Char], new Vector3(-5, 1, -5), Quaternion.identity);
            pm[2] = p[2].GetComponent<PlayerMovement>();
            pm[2].setControl("up","left","right","down");
            p[2].GetComponent<Renderer>().material = p2Mat;
        }
        if(playerCount>=3)
        {
            p[3] = Instantiate(chars[p3Char], new Vector3(5, 1, -5), Quaternion.identity);
            pm[3] = p[3].GetComponent<PlayerMovement>();
            pm[3].setControl("f","c","b","v");
            p[3].GetComponent<Renderer>().material = p3Mat;
        }
        if(playerCount>=4)
        {
            p[4] = Instantiate(chars[p4Char], new Vector3(-5, 1, 5), Quaternion.identity);
            pm[4] = p[4].GetComponent<PlayerMovement>();
            pm[4].setControl("u","h","k","j");
            p[4].GetComponent<Renderer>().material = p4Mat;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
