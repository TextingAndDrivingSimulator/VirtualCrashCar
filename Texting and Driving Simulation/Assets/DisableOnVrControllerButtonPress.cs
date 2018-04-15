using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOnVrControllerButtonPress : MonoBehaviour {
	public SteamVR_Controller.Device myDevice;
	public GameObject toDisable;
	// Use this for initialization
	void Start () {
		Debug.Log ("Printing sticks");
		string[] inputSticks = UnityEngine.Input.GetJoystickNames ();
		for (int i = 0; i != inputSticks.Length; ++i) {
			Debug.Log ("Stick number:" + i);
			Debug.Log (inputSticks [i]);
		}

	}
	
	// Update is called once per frame
	void Update () {
		
		float gripValue = Input.GetAxis ("GripButton");
	
		toDisable.SetActive (gripValue == 0);
	
	}
}
