using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    public Text raceTimeSecText;
    public Text raceTimeMinText;

    public GameObject quitPanel;

    public bool raceTrack = true;

    private int totalLaps = 3;
    private int totalCars = 1;

    // Start is called before the first frame update
    void Start()
    {
        quitPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            quitPanel.SetActive(true);
        }

        

        

        //Race Timer

        if(Counter.raceTimeMin <= 9)
        {

            raceTimeMinText.text = "0" + Mathf.Round(Counter.raceTimeMin).ToString() + ":";
            
        }

        else if(Counter.raceTimeMin >= 10)
        {

            raceTimeMinText.text = Mathf.Round(Counter.raceTimeMin).ToString() + ":";
            
        }

        if(Counter.raceTimeSec <= 9)
        {

            raceTimeSecText.text = "0" + Mathf.Round(Counter.raceTimeSec).ToString();
            
        }

        else if(Counter.raceTimeSec >= 10)
        {

            raceTimeSecText.text = Mathf.Round(Counter.raceTimeSec).ToString();
            
        }
        
    }

    public void GoToMenu()
    {

        SceneManager.LoadScene(1);
        Time.timeScale = 1f;

    }

    public void ReturnToMenu()
    {

        SceneManager.LoadScene(1);

    }

    public void CloseQuitPanel()
    {

        quitPanel.SetActive(false);

    }

}
