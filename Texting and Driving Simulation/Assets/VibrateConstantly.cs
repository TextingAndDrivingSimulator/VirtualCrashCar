using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateConstantly : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       
            // Vibrate controller L
            SteamVR_Controller.Input(
                SteamVR_Controller.GetDeviceIndex(
                    SteamVR_Controller.DeviceRelation.Leftmost)).TriggerHapticPulse(500);
            SteamVR_Controller.Input(
              SteamVR_Controller.GetDeviceIndex(
                  SteamVR_Controller.DeviceRelation.Rightmost)).TriggerHapticPulse(500);
        
    }
}
