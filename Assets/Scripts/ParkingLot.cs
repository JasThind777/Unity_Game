using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParkingLot : MonoBehaviour
{
    public GameObject Parking;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Parking.SetActive(true);
            Invoke("TextReset", 6f);
        }
    }

    public void TextReset()
    {
        Parking.SetActive(false);
    }
}
