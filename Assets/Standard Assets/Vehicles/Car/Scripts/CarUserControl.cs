using System.Runtime.InteropServices;
using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {
        private CarController m_Car; // the car controller we want to use
        private bool raceStart = false;


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

        void Start()
        {
            Invoke("RaceDelay", 3.5f);
        }

        void RaceDelay()
        {
            raceStart = true;
        }
        private void FixedUpdate()
        {
            if(raceStart)
            {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
            float v = CrossPlatformInputManager.GetAxis("Vertical");
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
            }
        }
    }
}
