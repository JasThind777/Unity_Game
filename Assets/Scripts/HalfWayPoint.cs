using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfWayPoint : MonoBehaviour
{

    public GameObject finishPoint;
    
    
    void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.CompareTag("Player"))
        {
            Counter.halfWayPoint = true;
            finishPoint.SetActive(true);  
        }
    }
}
