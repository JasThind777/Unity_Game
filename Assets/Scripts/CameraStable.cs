﻿using System.Numerics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Car;
        public float CarX;
        public float CarY;
        public float CarZ;
    
    // Update is called once per frame
    void Update()
    {

        CarX= Car.transform.eulerAngles.x;
        CarY= Car.transform.eulerAngles.y;
        CarZ= Car.transform.eulerAngles.z;

        transform.eulerAngles = new UnityEngine.Vector3(CarX - CarX, CarY , CarZ - CarZ);
        
    }

}
