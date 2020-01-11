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
    public TextMeshProUGUI stageSelectTxt;
    public string[] stages;
    public int stageNumber = 0;

    //For GameMode
    [Header("Game Mode")]
    public TextMeshProUGUI gameModeSelectTxt;
    public int gameModeNum;
    public int stockCount;
    public string[] gameModeTypeNames;

    public TextMeshProUGUI gameModeExtraSelectTxt;
    public TextMeshProUGUI gameModeExtraTxt;
    public string[] gameModeExtraNames;             //Extra reffers to stocks and times [just extra info the system needs]
    public int gameModeExtraNum = 3;

    //Player Character Choices
    [Header("Players Character")]


    public int[] pChar = new int[5];
    public string[] charNames;
    public TextMeshProUGUI[] playerCharDisplayer;   //Used in displaying the current name of the character the player is going to play
    public TextMeshProUGUI[] playerNumDisplayer;    //Used in making the different player names dissapear
    



    //Methods for buttons
    //Player Count Buttons
    public void BtnNextPC () 
    {
        if(playerCount + 1 < gallery.Length)
        {
            playerCount++;
            setPlayerActive();
        }
    }

    public void BtnPrevPC () 
    {
        if(playerCount - 1 > 0)
        {
            playerCount--;
            setPlayerUnActive();
        }
    }

    //Stage select buttons
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

        //GameMode buttons
        public void BtnNextGM () 
    {
        if(gameModeNum + 1 < gameModeTypeNames.Length)
        {
            gameModeNum++;
        }
    }

    public void BtnPrevGM () 
    {
        if(gameModeNum - 1 >= 0)
        {
            gameModeNum--;
        }
    }

    public void BtnNextGME () 
    {
        if(gameModeExtraNum + 1 < 100)
        {
            gameModeExtraNum++;
        }
    }

    public void BtnPrevGME () 
    {
        if(gameModeExtraNum - 1 > 0)
        {
            gameModeExtraNum--;
        }
    }

    //Character Select Buttons

    public void BtnNextChar1 () 
    {
        if(pChar[1] + 1 < charNames.Length)
        {
            pChar[1]++;
        }
    }

    public void BtnPrevChar1 () 
    {
        if(pChar[1] - 1 >= 0)
        {
            pChar[1]--;
        }
    }

        public void BtnNextChar2 () 
    {
        if(pChar[2] + 1 < charNames.Length)
        {
            pChar[2]++;
        }
    }

    public void BtnPrevChar2 () 
    {
        if(pChar[2] - 1 >= 0)
        {
            pChar[2]--;
        }
    }

    public void BtnNextChar3 () 
    {
        if(pChar[3] + 1 < charNames.Length)
        {
            pChar[3]++;
        }
    }

    public void BtnPrevChar3 () 
    {
        if(pChar[3] - 1 >= 0)
        {
            pChar[3]--;
        }
    }

    public void BtnNextChar4 () 
    {
        if(pChar[4] + 1 < charNames.Length)
        {
            pChar[4]++;
        }
    }

    public void BtnPrevChar4 () 
    {
        if(pChar[4] - 1 >= 0)
        {
            pChar[4]--;
        }
    }

    public void playBtn()
    {
        SceneManager.LoadScene(stageNumber+4); //Opens Scene for stage that corispones with stageNum [+4 is to bypass the title options charSelect and winner screen]
    }


    public void setPlayerActive()
    {
        for(int i = 1; i<=playerCount; i++)
            playerNumDisplayer[i].gameObject.SetActive(true);
    }
    public void setPlayerUnActive()
    {
        for(int i = playerCount + 1; i < gallery.Length; i++)
            playerNumDisplayer[i].gameObject.SetActive(false);        
    }

    // Start is called before the first frame update
    void Start()
    {
        playerNumDisplayer[3].gameObject.SetActive(false);
        playerNumDisplayer[4].gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        displayImage.sprite = gallery[playerCount];         //Updates player count icon and stage numver text
        stageSelectTxt.text = stages[stageNumber];
        gameModeSelectTxt.text = gameModeTypeNames[gameModeNum];
        gameModeExtraSelectTxt.text = gameModeExtraNames[gameModeNum];
        gameModeExtraTxt.text = gameModeExtraNum.ToString();
        
        for(int i = 1; i<5;i++)                             //Updates the player character choice on UI screen
        {
            playerCharDisplayer[i].text = charNames[pChar[i]];
        }
        
    }

    void OnDestroy()
    {
        PlayerPrefs.SetInt("stageNumber", stageNumber);
        PlayerPrefs.SetInt("playerCount", playerCount);

        PlayerPrefs.SetInt("p1Char", pChar[1]);
        PlayerPrefs.SetInt("p2Char", pChar[2]);
        PlayerPrefs.SetInt("p3Char", pChar[3]);
        PlayerPrefs.SetInt("p4Char", pChar[4]);
        
        if(gameModeNum == 0)
        {
            stockCount = gameModeExtraNum;
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
