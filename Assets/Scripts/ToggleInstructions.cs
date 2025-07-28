using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleInstructions : MonoBehaviour
{
    public GameObject instructions;

    

    // Start is called before the first frame update
    void Start()
    {
        Invoke("InstructionsOff", 20f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            instructions.SetActive(true);
            Invoke("InstructionsOff", 15f);
        }
    }

    void InstructionsOff()
    {
        instructions.SetActive(false);
    }
}
