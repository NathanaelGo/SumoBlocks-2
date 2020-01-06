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
    public GameObject[] chars;                          //Array of the different charcters
    public GameObject[] p =  new GameObject[5];         //Player Chararacters                                       Note Slot Zero is unused
    public int[] pChar = new int[5];                    //Int representing the which character the player picked    Note Slot Zero is unused


    [Header("Player Materials")]
    public Material[] pMat;

     
    [Header("Other")]  
    public string[] pMoveKeys = new string[5];          //Fill and slpit the keys and use it in revive                            
    public GameObject stageMangager;                    //Stage Manager Object
    public GameMode gmScript;                           //GameMode Script
    //Script holders for player Movement
    private PlayerMovement[] pm = new PlayerMovement[5];  //Player movement scripts                                 Note Slot Zero is unused



    void Start()
    {

        stageMangager = gameObject;
        gmScript = stageMangager.GetComponent<GameMode>();
        //Pulling Information from the Player pref void
        stageNumber = PlayerPrefs.GetInt("stageNumber", 0);
        playerCount = PlayerPrefs.GetInt("playerCount", 0);

        pChar[1] = PlayerPrefs.GetInt("p1Char", 0);
        pChar[2] = PlayerPrefs.GetInt("p2Char", 0);
        pChar[3] = PlayerPrefs.GetInt("p3Char", 0);
        pChar[4] = PlayerPrefs.GetInt("p4Char", 0);

        pMoveKeys[1] = "w a d s e q";
        pMoveKeys[2] = "up left right down , .";
        pMoveKeys[3] = "f c b v g d";
        pMoveKeys[4] = "u h k j i y";
        


        if(playerCount>=1)
        {
            p[1] = Instantiate(chars[pChar[1]], new Vector3(5, 1, 5), Quaternion.identity);
            pm[1] = p[1].GetComponent<PlayerMovement>();
            pm[1].setControl(pMoveKeys[1]);
            p[1].GetComponent<Renderer>().material = pMat[1];
        }
        if(playerCount>=2)
        {
            p[2] = Instantiate(chars[pChar[2]], new Vector3(-5, 1, -5), Quaternion.identity);
            pm[2] = p[2].GetComponent<PlayerMovement>();
            pm[2].setControl(pMoveKeys[2]);
            p[2].GetComponent<Renderer>().material = pMat[2];
        }
        if(playerCount>=3)
        {
            p[3] = Instantiate(chars[pChar[3]], new Vector3(5, 1, -5), Quaternion.identity);
            pm[3] = p[3].GetComponent<PlayerMovement>();
            pm[3].setControl(pMoveKeys[3]);
            p[3].GetComponent<Renderer>().material = pMat[3];
        }
        if(playerCount>=4)
        {
            p[4] = Instantiate(chars[pChar[4]], new Vector3(-5, 1, 5), Quaternion.identity);
            pm[4] = p[4].GetComponent<PlayerMovement>();
            pm[4].setControl(pMoveKeys[4]);
            p[4].GetComponent<Renderer>().material = pMat[4];
        }

    }

    public void revive(int playerNum)
    {
        Destroy(p[playerNum]);                                                                              //Destroys the old player block
        p[playerNum] = Instantiate(chars[pChar[playerNum]], new Vector3(0, 3, 0), Quaternion.identity);     //Creates a new model
        pm[playerNum] = p[playerNum].GetComponent<PlayerMovement>();                                        //Fetches the new playermovement script
        pm[playerNum].setControl(pMoveKeys[playerNum]);                                                     //Readds the new movement 
        p[playerNum].GetComponent<Renderer>().material = pMat[playerNum];                                   //Readds Color
    }
    

    // Update is called once per frame
    void Update()
    {
        for(int i = 1; i<=4; i++)
        {
            if(!(p[i]==null) && p[i].transform.position.y<-10)
            {
                if(gmScript.CharDestroyed(i))                       //Checks to see if it need to revive (handled by the gamemode script)
                    revive(i);
                else
                    Destroy(p[i]);
            }
        }
    }
}
