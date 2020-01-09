 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class VictoryScreen : MonoBehaviour
{

    public TextMeshProUGUI WinnerTxt;
    private int winnerNum;
    
    public void BtnGoToHomeScreen () 
    {
        SceneManager.LoadScene(2); 
    }

    // Start is called before the first frame update
    void Start()
    {
        winnerNum = PlayerPrefs.GetInt("Winner", 0);
        if(winnerNum != 0)
            WinnerTxt.text = string.Format("Player {0} Wins!!!",winnerNum);
        else
            WinnerTxt.text = "TIE!";       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
