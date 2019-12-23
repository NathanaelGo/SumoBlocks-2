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
    public GameObject myPrefab;
    public GameObject[] chars;

    public GameObject p1;
    public GameObject p2;
    public GameObject p3;
    public GameObject p4;

    public PlayerMovement p1m;


    void Start()
    {
        Debug.Log("Testo");
        stageNumber = PlayerPrefs.GetInt("stageNumber", 0);
        playerCount = PlayerPrefs.GetInt("playerCount", 0);

        p1Char = PlayerPrefs.GetInt("p1Char", 0);
        p2Char = PlayerPrefs.GetInt("p2Char", 0);
        p3Char = PlayerPrefs.GetInt("p3Char", 0);
        p4Char = PlayerPrefs.GetInt("p4Char", 0);

        Debug.Log(chars[1].GetType());
        p1 = Instantiate(chars[1], new Vector3(5, 1, 5), Quaternion.identity);
        Debug.Log("EEEE");
        p1m = p1.GetComponent<PlayerMovement>();
        Debug.Log(p1.GetType());

        //p2 = Instantiate(chars[0], new Vector3(5, 1, -5), Quaternion.identity);

        //p1m = p1.GetComponent<PlayerMovement>();
        //p1m.testoo();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
