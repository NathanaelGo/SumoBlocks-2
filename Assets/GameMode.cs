using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour
{

    public GameObject stageMangager;
    public int GameModeNum;
    public int stocks;
    public int[] pStocks;


    // Start is called before the first frame update
    void Start()
    {
        GameModeNum = PlayerPrefs.GetInt("GameModeNum", 0);
/* START HERE TOMMOROW 

        if(GameModeNum == 0)
        {
            stocks = PlayerPrefs.GetInt("Stocks",1);
            pStocks = new int[5];
            for(int i = 1; i<=4; i++) //Filling the life arrays with lives
            {
                pStocks[i] = stocks;
            }
            
        }
 */        
        //if(gmn == 0 ) then update stuff
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
