using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using Valve.VR.InteractionSystem;

namespace UnityStandardAssets.Vehicles.Car
{
    [RequireComponent(typeof (CarController))]
    public class CarUserControl : MonoBehaviour
    {

		private float normalizeToOne(float input) {
			if (input < -1) {
				return -1;
			}
			if (input > 1) {
				return 1;
			}
			return input;
		}
        private CarController m_Car; // the car controller we want to use

		public CircularDrive drive;

        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }


        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = CrossPlatformInputManager.GetAxis("Horizontal");
			Debug.Log ("Keyboard is " + h);

			float wheel_rotation = drive.outAngle;
			Debug.Log ("Raw wheel is " + wheel_rotation);
			wheel_rotation /= 360.0f;
			wheel_rotation = normalizeToOne (wheel_rotation);
			Debug.Log("Wheel is " + wheel_rotation);

			h += wheel_rotation;
			h = normalizeToOne (h);
		    

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

