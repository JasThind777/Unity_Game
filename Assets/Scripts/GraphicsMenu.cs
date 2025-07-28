using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GraphicsMenu : MonoBehaviour
{
    
    public Toggle fullscreenTog, vsyncTog;      //making a reference to toggle UI element of unity
    public ResItem[] resolutions;       //array to store the int values used for setting resolutions
    private int selectedResolution;     //variable to store the value of selected resolution on screen
    public TMP_Text resLabel;       //making a reference to text UI element of unity to show the current resolution

    // Start is called before the first frame update
    void Start()
    {
        
        //Refreshing selected graphic settings at the start of the game
        fullscreenTog.isOn = Screen.fullScreen;

        if(QualitySettings.vSyncCount == 0)
        {

            vsyncTog.isOn = false;

        }
        else 
        {

            vsyncTog.isOn = true;

        }

        // seraching the current resolution from the list.
        bool foundRes = false;

        for(int i = 0; i < resolutions.Length; i++)
        {

            if(Screen.width == resolutions[i].horizontal && Screen.height == resolutions[i].vertical)
            {

                foundRes = true;

                selectedResolution = i;

                UpdateResLabel();

            }

        }

        if(!foundRes)
        {

            resLabel.text = Screen.width.ToString() + " x " + Screen.height.ToString();

        }

    }

    // Update is called once per frame
    void Update()
    {


        
    }


    
    public void ResLeft()
    {

        selectedResolution-- ;
        if(selectedResolution < 0)
        {

            selectedResolution = 0;

        }

        UpdateResLabel();

    }

    public void ResRight()
    {

        selectedResolution++ ;
        if(selectedResolution > resolutions.Length - 1)
        {

            selectedResolution = resolutions.Length - 1;

        }

        UpdateResLabel();

    }

    public void UpdateResLabel()
    {

        resLabel.text = resolutions[selectedResolution].horizontal.ToString() + " x " + resolutions[selectedResolution].vertical.ToString();

    }

    public void Apply()
    {

        // Fullscreen Mode 
        Screen.fullScreen = fullscreenTog.isOn;

        // Vsync
        if(vsyncTog.isOn)
        {

            QualitySettings.vSyncCount = 1;

        }
        else
        {

            QualitySettings.vSyncCount = 0;

        }

        // Set the Resulotions
        Screen.SetResolution(resolutions[selectedResolution].horizontal, resolutions[selectedResolution].vertical, fullscreenTog.isOn);

    }
}

[System.Serializable]

public class ResItem
{

    public int horizontal, vertical;

}
