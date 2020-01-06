using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterMangaerSettings : MonoBehaviour
{
    //For Player Count (PC)
    [Header("Player Count")]
    public Sprite[] gallery; //store all your images in here at design time
    public Image displayImage; //The current image thats visible
    public int playerCount = 0; //Will control where in the array you are
    
    //For Stage Select
    [Header("Stage Select")]    
    public TextMeshProUGUI txt;
    public string[] stages;
    public int stageNumber = 0;

    //For GameMode
    public int gameModeNum;
    public int stockCount;

    //Player Character Choices
    [Header("Players Character")]
    public int p1Char = 0;
    public int p2Char = 0;
    public int p3Char = 0;
    public int p4Char = 0;


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
    if(stageNumber + 1 < stages.Length)
        {
            stageNumber++;
        }
    }

    public void BtnPrevStage () 
    {
        if(stageNumber - 1 >= 0)
        {
            stageNumber--;
        }
    }

    public void playBtn()
    {
        SceneManager.LoadScene(stageNumber+3); //Opens Scene for stage that corispones with stageNum [+3 is to bypass the title options and charSelect]
    }

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        displayImage.sprite = gallery[playerCount];         //Updates player count icon and stage numver text
        txt.text = stages[stageNumber];
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("stageNumber", stageNumber);
        PlayerPrefs.SetInt("playerCount", playerCount);

        PlayerPrefs.SetInt("p1Char", p1Char);
        PlayerPrefs.SetInt("p2Char", p2Char);
        PlayerPrefs.SetInt("p3Char", p3Char);
        PlayerPrefs.SetInt("p4Char", p4Char);
        
        if(gameModeNum == 0)
        {
            if(stockCount == null || stockCount == 0)
                stockCount = 3;

            PlayerPrefs.SetInt("Stocks", stockCount);
        }
        else                                                //Holder Will be changed in the future
        {
            PlayerPrefs.SetInt("Stocks", 1);
        }
    }
}
