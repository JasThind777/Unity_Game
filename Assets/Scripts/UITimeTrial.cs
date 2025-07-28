using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UITimeTrial : MonoBehaviour
{

    
    public Text timeTrialMinG;
    public Text timeTrialMinS;
    public Text timeTrialMinB;
    public Text timeTrialSecG;
    public Text timeTrialSecS;
    public Text timeTrialSecB;
    public Text winMessage;

    public GameObject TimeTrialObj;
    public GameObject timeTrialResults;
    public GameObject goldStar;
    public GameObject silverStar;
    public GameObject bronzeStar;
    public GameObject quitPanel;

    private bool winner = false;

   

    // Start is called before the first frame update
    void Start()
    {

        TimeTrialObj.SetActive(true);
        timeTrialResults.SetActive(false);
        quitPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {

        //Time Trials Time Test
        //Gold Time 
        if(Counter.timeTrialMinG <= 9)
        {
            timeTrialMinG.text = "0" + Counter.timeTrialMinG.ToString() + ":";            
        }

        else if(Counter.timeTrialMinG >= 10)
        {            
            timeTrialMinG.text = Counter.timeTrialMinG.ToString() + ":";
        }

        if(Counter.timeTrialSecG <= 9)
        {
            timeTrialSecG.text = "0" + Counter.timeTrialSecG.ToString();            
        }

        else if(Counter.timeTrialSecG >= 10)
        {            
            timeTrialSecG.text = Counter.timeTrialSecG.ToString();
        }

        //Silver Time
        if(Counter.timeTrialMinS <= 9)
        {
            timeTrialMinS.text = "0" + Counter.timeTrialMinS.ToString() + ":";            
        }

        else if(Counter.timeTrialMinS >= 10)
        {            
            timeTrialMinS.text = Counter.timeTrialMinS.ToString() + ":";
        }

        if(Counter.timeTrialSecS <= 9)
        {
            timeTrialSecS.text = "0" + Counter.timeTrialSecS.ToString();            
        }

        else if(Counter.timeTrialSecS >= 10)
        {            
            timeTrialSecS.text = Counter.timeTrialSecS.ToString();
        } 

        //Bronze time
        if(Counter.timeTrialMinB <= 9)
        {
            timeTrialMinB.text = "0" + Counter.timeTrialMinB.ToString() + ":";            
        }

        else if(Counter.timeTrialMinB >= 10)
        {            
            timeTrialMinB.text = Counter.timeTrialMinB.ToString() + ":";
        }

        if(Counter.timeTrialSecB <= 9)
        {
            timeTrialSecB.text = "0" + Counter.timeTrialSecB.ToString();            
        }

        else if(Counter.timeTrialSecB >= 10)
        {            
            timeTrialSecB.text = Counter.timeTrialSecB.ToString();
        }

        if(Counter.raceOver == true)
        {

            if(winner == false)
            {

                winner = true;
                Invoke("WinMessage", 0.15f);

            }

        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {

            quitPanel.SetActive(true);

        }
        
    }

    void WinMessage()
    {

        timeTrialResults.SetActive(true);

        if(Counter.gold == true)
        {

            winMessage.text = "YOU WON THE GOLD STAR";
            goldStar.SetActive(true);
            SaveScript.racesWon++;

        }

        if(Counter.silver == true)
        {

            winMessage.text = "YOU WON THE SILVER STAR";
            silverStar.SetActive(true);
            SaveScript.racesWon++;

        }

        if(Counter.bronze == true)
        {

            winMessage.text = "YOU WON THE BRONZE STAR";
            bronzeStar.SetActive(true);
            SaveScript.racesWon++;

        }

        if(Counter.failed == true)
        {

            winMessage.text = "YOU HAVE FAILED, PLEASE TRY AGAIN";
            SaveScript.racesLost++;

        }

        SaveScript.saving = true;

    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(1);
        Counter.raceOver = false;
        Time.timeScale = 1;
    }

    public void CloseQuitPanel()
    {

        quitPanel.SetActive(false);

    }

}
