using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CharacterMangaerSettings : MonoBehaviour
{
    //For Player Count (PC)
    public Sprite[] gallery; //store all your images in here at design time
    public Image displayImage; //The current image thats visible
    public int playerCount = 0; //Will control where in the array you are
    
    //For Stage Select
    public TextMeshProUGUI txt;
    public string[] stages;
    public int StageNumber = 0;


    /*
    //List<String> charList = { "Jeff", 
    //                       "Fatty", 
    //                       "Speedy"};
    int p1p = 0;
    int p2p = 0;
    int p3p = 0;
    int p4p = 0;
    */


    //Methods for buttons
    public void BtnNextPC () 
    {
    if(playerCount + 1 < gallery.Length)
        {
            playerCount++;
        }
    }

    public void BtnPrevPC () 
    {
        if(playerCount - 1 > 0)
        {
            playerCount--;
        }
    }

    public void BtnNextStage () 
    {
    if(StageNumber + 1 < stages.Length)
        {
            StageNumber++;
        }
    }

    public void BtnPrevStage () 
    {
        if(StageNumber - 1 >= 0)
        {
            StageNumber--;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayImage.sprite = gallery[playerCount];         //Updates player count icon and stage numver text
        txt.text = stages[StageNumber];
    }
}
