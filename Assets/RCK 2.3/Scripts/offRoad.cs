using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class offRoad : MonoBehaviour
{
    public GameObject warning;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Grass"))
        {
            warning.SetActive(true);
        }
    }

}
