using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{

    public GameObject leaderBoard;

    private string playerName;
    public static string pName;

    public static int playerFinishPos;

    void Start()
    {

        playerName = SaveScript.playerName;
        pName = playerName;

    }
    
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.CompareTag("Player"))
        {
            Counter.raceOver = true;
            Time.timeScale = 0.3f;
            leaderBoard.SetActive(true);
        }
        
    }
    
}
