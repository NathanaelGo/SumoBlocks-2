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
    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;


    public Material p1Mat;
    public Material p2Mat;
    public Material p3Mat;
    public Material p4Mat;
     

    //Script holders
    private PlayerMovement p1m;
    private PlayerMovement p2m;
    private PlayerMovement p3m;
    private PlayerMovement p4m;



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
            p1 = Instantiate(chars[p1Char], new Vector3(5, 1, 5), Quaternion.identity);
            p1m = p1.GetComponent<PlayerMovement>();
            p1m.setControl("w","a","d","s");
            p1.GetComponent<Renderer>().material = p1Mat;
        }
        if(playerCount>=2)
        {
            p2 = Instantiate(chars[p2Char], new Vector3(-5, 1, -5), Quaternion.identity);
            p2m = p2.GetComponent<PlayerMovement>();
            p2m.setControl("up","left","right","down");
            p2.GetComponent<Renderer>().material = p2Mat;
        }
        if(playerCount>=3)
        {
            p3 = Instantiate(chars[p3Char], new Vector3(5, 1, -5), Quaternion.identity);
            p3m = p3.GetComponent<PlayerMovement>();
            p3m.setControl("f","c","b","v");
            p3.GetComponent<Renderer>().material = p3Mat;
        }
        if(playerCount>=4)
        {
            p4 = Instantiate(chars[p4Char], new Vector3(-5, 1, 5), Quaternion.identity);
            p4m = p4.GetComponent<PlayerMovement>();
            p4m.setControl("u","h","k","j");
            p4.GetComponent<Renderer>().material = p4Mat;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
