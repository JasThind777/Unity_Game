using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static float raceTimeSec;
    public static float raceTimeMin;
    public static float gameTime;
    public static float timeTrialMinG;
    public static float timeTrialMinS;
    public static float timeTrialMinB;
    public static float timeTrialSecG;
    public static float timeTrialSecS;
    public static float timeTrialSecB;

    public static bool halfWayPoint = true; 
    public static bool WWWReset = false; 
    public static bool raceStart = false; 
    public static bool raceOver = false;
    public static bool gold = false;
    public static bool silver = false;
    public static bool bronze = false;
    public static bool failed = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
        if(raceOver == false)
        {

            if(raceStart == true)
            {
                raceTimeSec += Time.deltaTime;
                gameTime += Time.deltaTime;
            }

            if(raceTimeSec > 59)
            {

                raceTimeSec = 0f;
                raceTimeMin++;

            }

        }
        
    }

}
