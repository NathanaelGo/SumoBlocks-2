using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{

    public GameObject stageMangager;        //Stage Manager Object
    public StageManager smScript;           //Stage Manager script
    public int GameModeNum;
    public int stocks;
    public int[] pStocks;
    

    //        playerCount = PlayerPrefs.GetInt("playerCount", 0);


    public bool CharDestroyed(int charNum)
    {
        if(GameModeNum == 0)
        {
            pStocks[charNum] = pStocks[charNum] - 1;
            if(pStocks[charNum]>0)
                return true;
            else
            {
                if(playersLeftAlive().Length == 1)      //Returns the player number of the last person alive
                {
                    Debug.Log(playersLeftAlive()[0]);
                }
                else if(playersLeftAlive().Length == 0) //If players die at the exact same time
                {
                    Debug.Log("TIE");
                }
                return false;
            }   
            
        }
        return true;
    }

    public int[] playersLeftAlive()       //Return array of player numbers who are alive/left with stocks 
    {
        int playerCount = PlayerPrefs.GetInt("playerCount", 0);
        List<int> playersLeft = new List<int>();

        for(int i = 1; i <= playerCount; i++)
        {
            if(pStocks[i]>0)
                playersLeft.Add(i);
        }
        
        return playersLeft.ToArray();
    }

    // Start is called before the first frame update
    void Start()
    {
        stageMangager = gameObject;
        smScript = stageMangager.GetComponent<StageManager>();
        GameModeNum = PlayerPrefs.GetInt("GameModeNum", 0);


        if(GameModeNum == 0)
        {
            stocks = PlayerPrefs.GetInt("Stocks",1);
            pStocks = new int[5];
            for(int i = 1; i<=4; i++) //Filling the life arrays with lives
            {
                pStocks[i] = stocks;
            }
            
        }
        
        //if(gmn == 0 ) then update stuff
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
