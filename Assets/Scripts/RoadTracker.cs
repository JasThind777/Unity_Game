using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTracker : MonoBehaviour
{
    public GameObject warning;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            warning.SetActive(true);
            Invoke("ResetDelay", 10f);
        }
    }

    void ResetDelay()
    {
        warning.SetActive(false);
    }
}
