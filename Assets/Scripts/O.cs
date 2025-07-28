using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI
;
public class O : MonoBehaviour
{

    public GameObject startMenuScreen, optionsScreen, graphicsScreen, audioScreen;

    //string variable to hold the name of the scene after play button is clicked
    public int selectedLevelIndex;

    public GameObject loadingScreen, loadingIcon;
    
    public Text loadingText;
    

    public void StartGame()
    {

        //SceneManager.LoadScene(selectedLevelIndex);
        StartCoroutine(LoadGame());

    }

    public void PlayBTN()
    {

        StartCoroutine(LoadScene());

    }

    public void OpenOptions()
    {

        optionsScreen.SetActive(true);
        startMenuScreen.SetActive(false);

    }

    public void CloseOptions()
    {

        optionsScreen.SetActive(false);
        startMenuScreen.SetActive(true);

    }

    public void OpenGraphicSettings()
    {

        graphicsScreen.SetActive(true);
        optionsScreen.SetActive(false);

    }

    public void CloseGraphicSettings()
    {

        graphicsScreen.SetActive(false);
        optionsScreen.SetActive(true);

    }

    public void OpenAudioSettings()
    {

        audioScreen.SetActive(true);
        optionsScreen.SetActive(false);

    }

    public void CloseAudioSettings()
    {

        audioScreen.SetActive(false);
        optionsScreen.SetActive(true);

    }

    public void QuitGame()
    {

        Application.Quit();
        //Debug.Log("quit game");

    }

    public IEnumerator LoadGame()
    {

        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(selectedLevelIndex);

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {

            if(asyncLoad.progress >= .9f)
            {

                loadingText.text = "Press any key to continue";

                if(Input.anyKeyDown)
                {

                    asyncLoad.allowSceneActivation = true;

                }
            }

            yield return null;
        }
    }

    public IEnumerator LoadScene()
    {

        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(2);

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {

            if(asyncLoad.progress >= .9f)
            {

                loadingText.text = "Press any key to continue";

                if(Input.anyKeyDown)
                {

                    asyncLoad.allowSceneActivation = true;

                }
            }

            yield return null;
        }
    }

}
