using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReverseCamera : MonoBehaviour
{
    public GameObject MainCamera;
    public GameObject BackCamera;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            MainCamera.SetActive(false);
            BackCamera.SetActive(true);
        }
        else
        {
            MainCamera.SetActive(true);
            BackCamera.SetActive(false);
        }
    }
}
