using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour
{
    public GameObject mainCam;
    public GameObject FrontCam;
    public GameObject insideCam;

    private int carID = 1;
    public int maxCams = 3;
    // Start is called before the first frame update
    void Start()
    {
     mainCam.SetActive(true);
     FrontCam.SetActive(false);
     insideCam.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            carID++;
        }
        if(carID > maxCams)
            {
                carID = 1;
            }
        if(carID == 1)
        {
            mainCam.SetActive(true);
            FrontCam.SetActive(false);
            insideCam.SetActive(false); 
        }
        if(carID == 2)
        {
             mainCam.SetActive(false);
            FrontCam.SetActive(true);
            insideCam.SetActive(false); 
        }
        if(carID == 3)
        {
            mainCam.SetActive(false);
            FrontCam.SetActive(false);
            insideCam.SetActive(true); 
        }
    }
}
