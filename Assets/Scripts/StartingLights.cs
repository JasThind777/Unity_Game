using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingLights : MonoBehaviour
{

    public GameObject RLightOff;
    public GameObject RLightOn;
    public GameObject YLightOff;
    public GameObject YLightOn;
    public GameObject GLightOff;
    public GameObject GLightOn;
    public GameObject Go;

    public AudioSource LSound;
    public AudioSource GoSound;

    // Start is called before the first frame update
    void Start()
    {

        Go.SetActive(false);

        StartCoroutine(StartingLight());
        
    }

    IEnumerator StartingLight()
    {
        
        yield return new WaitForSeconds(1);
        RLightOff.SetActive(false);
        RLightOn.SetActive(true);
        LSound.Play();
        yield return new WaitForSeconds(1);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        LSound.Play();
        YLightOff.SetActive(false);
        YLightOn.SetActive(true);
        yield return new WaitForSeconds(1);
        YLightOff.SetActive(true);
        YLightOn.SetActive(false);
        LSound.Play();
        GLightOff.SetActive(false);
        GLightOn.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        Counter.raceStart = true;
        Go.SetActive(true);
        GoSound.Play();
        yield return new WaitForSeconds(1);
        Go.SetActive(false);

    }

}
