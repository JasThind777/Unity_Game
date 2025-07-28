using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScript : MonoBehaviour
{



    public  static int racesWon = 0;
    public  static int racesLost = 0;

    public static string playerName = "Player";

    public static bool saving = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this);
        LoadStats();    
    }

    void Update()
    {
        if(saving == true)
        {
            SaveStats();
            saving = false;
        }
    }

    public void SaveStats()
    {
        PlayerPrefs.SetString("MyName", playerName);
        PlayerPrefs.SetInt("WonRaces", racesWon);
        PlayerPrefs.SetInt("LostRaces", racesLost);
    }

    public void LoadStats()
    {
        playerName = PlayerPrefs.GetString("MyName");
        racesWon = PlayerPrefs.GetInt("WonRaces");
        racesLost = PlayerPrefs.GetInt("LostRaces");
    }
}
