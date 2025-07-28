using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioMixer aMixer;
    // Start is called before the first frame update
    void Start()
    {
        //At the start of the scene checking if changes were made/saved for audio settings by the player.
        if(PlayerPrefs.HasKey("MasterVol"))
        {
            //applying the changes made to audio setting at the start of the scene.    
            aMixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("MasterVol"));

        }

        if(PlayerPrefs.HasKey("MusicVol"))
        {

            aMixer.SetFloat("MusicVol", PlayerPrefs.GetFloat("MusicVol"));
           
        }

        if(PlayerPrefs.HasKey("SFXVol"))
        {

            aMixer.SetFloat("SFXVol", PlayerPrefs.GetFloat("SFXVol"));

        }
        
    }

}
