using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texting : MonoBehaviour {
	public Text textMessages;

	//****************** CITATION *********************************
	//Inspiration for reading Vive trackpad input from YouTube Tutorial
	//"Unity VR: Vive Touchpad Input Mapping Tutorial(SteamVR)" by Leading Ones
	//https://www.youtube.com/watch?v=Awr52z9Y670
	//*************************************************************


	private SteamVR_TrackedObject trackedObject;
	private SteamVR_Controller.Device device;

	private SteamVR_TrackedController controller;

	void Start () {
		//trackedObject = GetComponent<SteamVR_TrackedObject>();
		//controller = GetComponent<SteamVR_TrackedController> ();
		//controller.PadClicked += Controller_PadClicked;

		textMessages.text = "Welcome to your smart phone!";
	}

	void Controller_PadClicked (object sender, ClickedEventArgs e)
	{
		if (device.GetAxis ().x != 0 || device.GetAxis ().y != 0) {
			Debug.Log (device.GetAxis ().x + " " + device.GetAxis ().y);
		}

		//Reading out x,y values to find button selected
		/*
		if (device.GetAxis ().x > 0 && device.GetAxis ().y > 0) {
			//2 selected
		} else if (device.GetAxis ().x > 0 && device.GetAxis ().y < 0) {
			//4 selected
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y > 0) {
			//1 selected
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y < 0) {
			//3 selected
		}*/

	}

	void Update () {
		//device = SteamVR_Controller.Input ((int)trackedObject.index);
		if (Input.GetMouseButtonDown (0)) {
			textMessages.text = "Use the four buttons to select different message options.";
		}
	}
}
