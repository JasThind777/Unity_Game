using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisionDetect : MonoBehaviour
{
    public Text Warning;
    public bool Collision = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Collision)
        {
            Warning.text = "BE CARFUL, YOU TO CLOSE";
            Invoke("WarningReset", 0.8f);
        }
        if(!Collision)
        {
            Warning.text = " ";
        }
    }

    void WarningReset()
    {
        Collision = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Collision = true;
        }
    }
}
