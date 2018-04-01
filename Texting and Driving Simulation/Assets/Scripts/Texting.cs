using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Texting : MonoBehaviour {
	public Text textMessages;
	public TextBank textBank;

	//****************** CITATION *********************************
	//Inspiration for reading Vive trackpad input from YouTube Tutorial
	//"Unity VR: Vive Touchpad Input Mapping Tutorial(SteamVR)" by Leading Ones
	//https://www.youtube.com/watch?v=Awr52z9Y670
	//*************************************************************


	private SteamVR_TrackedObject trackedObject;
	private SteamVR_Controller.Device device;

	private SteamVR_TrackedController controller;

	void Start () {
		//trackedObject = GetComponent<SteamVR_TrackedObject>();    //toggle
		//controller = GetComponent<SteamVR_TrackedController> ();   //toggle
		//controller.PadClicked += Controller_PadClicked;           //toggle

		textMessages.text = "Welcome to your smart phone!";
	}

	void Controller_PadClicked (object sender, ClickedEventArgs e)
	{
		if (device.GetAxis ().x != 0 || device.GetAxis ().y != 0) {
			Debug.Log (device.GetAxis ().x + " " + device.GetAxis ().y);
		}

		//Reading out x,y values to find button selected
		
		if (device.GetAxis ().x > 0 && device.GetAxis ().y > 0) {
			//b selected
		} else if (device.GetAxis ().x > 0 && device.GetAxis ().y < 0) {
			//c selected
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y > 0) {
			//a selected
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y < 0) {
			//d selected
		}

	}

	void Update () {
		//device = SteamVR_Controller.Input ((int)trackedObject.index);   //toggle
        
        //USE a,b,c,d on keyboard for testing purposes
        

		//Josh's String Testing Below
		if (Input.GetMouseButtonDown (0)) {
			textMessages.text = textBank.s1;
		}
	}
}
