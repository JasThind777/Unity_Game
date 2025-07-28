using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class AudioMenu : MonoBehaviour
{

    public AudioMixer aMixer;    // variable to hold the unity audio mixer to reference in the script.

    public Slider mastSlider;    //variable to hold the slider UI Element to reference in script

    public Slider musicSlider;    //variable to hold the slider UI Element to reference in script

    public Slider sfxSlider;     //variable to hold the slider UI Element to reference in script

    public TMP_Text mastLabel, musicLabel, sfxLabel;    //variable to hold the Text UI Element to reference in script(TMP stands for text mesh pro newer/better version of text .... maybe)

    //public AudioSource sfx;      //to hold an audio file to reference in script

    // Start is called before the first frame update
    void Start()
    {
        //At the start of the scene checking if changes were made/saved for audio settings by the player.
        if(PlayerPrefs.HasKey("MasterVol"))
        {
            //applying the changes made to audio setting at the start of the scene.    
            aMixer.SetFloat("MasterVol", PlayerPrefs.GetFloat("MasterVol"));     //setting the value saved by the player to the audio mixer.
            mastSlider.value = PlayerPrefs.GetFloat("MasterVol");    //setting the sliders value to the saved audio settings
            
        }

        if(PlayerPrefs.HasKey("MusicVol"))
        {

            aMixer.SetFloat("MusicVol", PlayerPrefs.GetFloat("MusicVol"));
            musicSlider.value = PlayerPrefs.GetFloat("MusicVol");
        
        }

        if(PlayerPrefs.HasKey("SFXVol"))
        {

            aMixer.SetFloat("SFXVol", PlayerPrefs.GetFloat("SFXVol"));
            sfxSlider.value = PlayerPrefs.GetFloat("SFXVol");
            
        }

        MasterVolLabel();

        MusicVolLabel();

        SFXVolLabel();
        
    }

    // Update is called once per frame
    void Update()
    {

        MasterVolLabel();

        MusicVolLabel();

        SFXVolLabel();
        
    }

    public void MasterVolLabel()
    {

        //audio mixers have values through -20 to 80 for player's sanity this modifies the value of slider by adding 80 to show the value through 0 to 100
        mastLabel.text = (mastSlider.value + 80).ToString();    //showing the modified value of slider in text beside it.

    }

    public void MusicVolLabel()
    {

        musicLabel.text = (musicSlider.value + 80).ToString();

    }

    public void SFXVolLabel()
    {

        sfxLabel.text = (sfxSlider.value + 80).ToString();

        aMixer.SetFloat("SFXVol", sfxSlider.value);

    }

    //Applying the changes made by the player.
    public void ApplyAudio()
    {

        aMixer.SetFloat("MasterVol", mastSlider.value);     //changing the values of the unity audio mixer according to the values of sliders.

        PlayerPrefs.SetFloat("MasterVol", mastSlider.value);    //saving the changes made by the player to reference later.

        aMixer.SetFloat("MusicVol", musicSlider.value);

        PlayerPrefs.SetFloat("MusicVol", musicSlider.value);

        aMixer.SetFloat("SFXVol", sfxSlider.value);

        PlayerPrefs.SetFloat("SFXVol", sfxSlider.value);

    }
}