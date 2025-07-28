using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLights : MonoBehaviour
{

    public GameObject RLightOff;
    public GameObject RLightOn;
    public GameObject YLightOff;
    public GameObject YLightOn;
    public GameObject GLightOff;
    public GameObject GLightOn;

    // Start is called before the first frame update
    void Start()
    {
        RLightOff.SetActive(false);
        RLightOn.SetActive(true);
        YLightOff.SetActive(true);
        YLightOn.SetActive(false);
        GLightOff.SetActive(true);
        GLightOn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(IntersectionDetect.nearIntersection == true)
        {
            StartCoroutine(TrafficLight());
        }   
    }

    IEnumerator TrafficLight()
    {
        IntersectionDetect.nearIntersection = false;
        yield return new WaitForSeconds(4);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        YLightOff.SetActive(false);
        YLightOn.SetActive(true);
        GLightOff.SetActive(true);
        GLightOn.SetActive(false);
        yield return new WaitForSeconds(3);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        YLightOff.SetActive(true);
        YLightOn.SetActive(false);
        GLightOff.SetActive(false);
        GLightOn.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        RLightOff.SetActive(false);
        RLightOn.SetActive(true);
        YLightOff.SetActive(true);
        YLightOn.SetActive(false);
        GLightOff.SetActive(true);
        GLightOn.SetActive(false);
        yield return new WaitForSeconds(5);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        YLightOff.SetActive(false);
        YLightOn.SetActive(true);
        GLightOff.SetActive(true);
        GLightOn.SetActive(false);
        yield return new WaitForSeconds(3);
        RLightOff.SetActive(true);
        RLightOn.SetActive(false);
        YLightOff.SetActive(true);
        YLightOn.SetActive(false);
        GLightOff.SetActive(false);
        GLightOn.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        RLightOff.SetActive(false);
        RLightOn.SetActive(true);
        YLightOff.SetActive(true);
        YLightOn.SetActive(false);
        GLightOff.SetActive(true);
        GLightOn.SetActive(false);
        
    }
}
