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


        private void Awake()
        {
            // get the car controller
            m_Car = GetComponent<CarController>();
        }

		public ReadPotentiometerFromArduino wheel_values;

		public GameObject wheelToRotate;

        private void FixedUpdate()
        {
            // pass the input to the car!
            float h = 0;
			if (Input.GetKey ("a")) {
				h += -1;
			}
			if (Input.GetKey ("d")) {
				h += 1;
			}

			int arduino_reading = wheel_values.GetWheelCurrentValue ();
			if (arduino_reading != -1) {
				float wheel_rotation = arduino_reading;
				wheel_rotation -= 1023 / 2.0f;
				wheel_rotation /= 1023 / 2.0f;
				wheel_rotation = normalizeToOne (wheel_rotation);
		

				h += wheel_rotation;
				h = normalizeToOne (h);
			}
			Vector3 newLocalRotation = new Vector3 (0, h * 180.0f, 0);
			wheelToRotate.transform.localRotation = Quaternion.Euler( newLocalRotation );
			float v = 0;
			if ( Input.GetKey("w") ) {
				v = 1;
			} 
			if ( Input.GetKey("s") ) {
				v = -1;
			}
#if !MOBILE_INPUT
            float handbrake = CrossPlatformInputManager.GetAxis("Jump");
            m_Car.Move(h/3.0f, v, v, handbrake);
#else
            m_Car.Move(h, v, v, 0f);
#endif
        }
    }
}

