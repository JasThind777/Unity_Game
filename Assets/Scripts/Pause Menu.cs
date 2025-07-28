using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenuScreen : MonoBehaviour
{
    public GameObject optionsScreen, pauseScreen, pauseMenuScreen;

    public int mainMenuScene = 1;

    private bool isPaused;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }
    }

    public void PauseUnpause()
    {
        if(!isPaused)
        {
            pauseScreen.SetActive(true);
            isPaused = true;

            Time.timeScale = 0f;
        } else
        {
            pauseScreen.SetActive(false);
            isPaused = false;

            Time.timeScale = 1f;
        }
    }

    public void OpenPauseMenu()
    {

        pauseMenuScreen.SetActive(true);

    }

    public void ClosePauseMenu()
    {

        pauseMenuScreen.SetActive(false);

    }

    public void OpenOptions()
    {
        optionsScreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsScreen.SetActive(false);
    }

    public void QuitToMain()
    {
        SceneManager.LoadScene(mainMenuScene);

        Time.timeScale = 1f;

        
    }

}
