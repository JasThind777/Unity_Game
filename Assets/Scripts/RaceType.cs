using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceType : MonoBehaviour
{
    public bool timeTrial = true;

    public float goldTimeMin;
    public float goldTimeSec;
    public float silverTimeMin;
    public float silverTimeSec;
    public float bronzeTimeMin;
    public float bronzeTimeSec;

    // Start is called before the first frame update
    void Start()
    {

        if(timeTrial == true)
        {

            Counter.timeTrialMinG = goldTimeMin;
            Counter.timeTrialSecG = goldTimeSec;
            Counter.timeTrialMinS = silverTimeMin;
            Counter.timeTrialSecS = silverTimeSec;
            Counter.timeTrialMinB = bronzeTimeMin;
            Counter.timeTrialSecB = bronzeTimeSec;
            

        }
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Counter.raceOver == true)
        {

            if(timeTrial == true)
            {
                if(Counter.raceTimeMin <= goldTimeMin && (Counter.raceTimeSec) < goldTimeSec)
                {
                    Counter.gold = true;
                }

                if(Counter.raceTimeMin <= silverTimeMin && (Counter.raceTimeSec) < silverTimeSec)
                {
                    if(Counter.gold == false)
                    {    
                        Counter.silver = true;
                    }
                }

                if(Counter.raceTimeMin <= bronzeTimeMin && (Counter.raceTimeSec) < bronzeTimeSec)
                {
                    if(Counter.gold == false && Counter.silver == false)
                    {  
                        Counter.bronze = true;
                    }
                }

                else if(Counter.gold == false && Counter.silver == false && Counter.bronze == false)
                    {  
                        Counter.failed = true;
                    }
            }
        } 
    }
}
