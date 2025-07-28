using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IntersectionDetect : MonoBehaviour
{
    public Text lookAtLights;

    public bool I0;
    public bool I1;
    public bool I2;
    public bool I3;
    public bool I4;
    public bool I5;
    public bool I6;
    public bool I7;
    public static bool nearIntersection = false;
    public static bool nearIntersection1 = false;
    public static bool nearIntersection2 = false;
    public static bool nearIntersection3 = false;
    public static bool nearIntersection4 = false;
    public static bool nearIntersection5 = false;
    public static bool nearIntersection6 = false;
    public static bool nearIntersection7 = false;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            lookAtLights.text = "CHECK THE LIGHTS BEFORE MAKING THE TURN";
            if(I0)
            {
                nearIntersection = true;
            }
            if(I1)
            {
                nearIntersection1 = true;
            }
            if(I2)
            {
                nearIntersection2 = true;
            }
            if(I3)
            {
                nearIntersection3 = true;
            }
            if(I4)
            {
                nearIntersection4 = true;
            }
            if(I5)
            {
                nearIntersection5 = true;
            }
            if(I6)
            {
                nearIntersection6 = true;
            }
            if(I7)
            {
                nearIntersection7 = true;
            }
        }
    }

    void Update()
    {
        if(nearIntersection)
        {
            Invoke("ResetText", 4f);
        }
        if(nearIntersection2)
        {
            Invoke("ResetText", 4f);
        }
        if(nearIntersection3)
        {
            Invoke("ResetText", 4f);
        }
        if(nearIntersection4)
        {
            Invoke("ResetText", 4f);
        }
        if(nearIntersection5)
        {
            Invoke("ResetText", 4f);
        }
        if(nearIntersection6)
        {
            Invoke("ResetText", 4f);
        }
        if(nearIntersection1)
        {
            Invoke("ResetText", 4f);
        }
        if(nearIntersection7)
        {
            Invoke("ResetText", 4f);
        }
    }

    void ResetText()
    {
        lookAtLights.text = " ";
    }
}
