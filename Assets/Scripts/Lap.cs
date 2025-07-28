using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lap : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.CompareTag("Player"))
        {
            Counter.WWWReset = true;
            if(Counter.raceOver == false)
            {
                if(Counter.halfWayPoint == true)
                {
                    Counter.halfWayPoint = false;                   
                }               
            }    
        }  
    }
}
