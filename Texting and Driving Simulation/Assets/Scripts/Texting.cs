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

	public bool enableVRControls = false;
    public int currentText;

	private void VibrateController() {
		if (enableVRControls) {
            // Vibrate controller L
            SteamVR_Controller.Input(
                SteamVR_Controller.GetDeviceIndex(
                    SteamVR_Controller.DeviceRelation.Leftmost)).TriggerHapticPulse(500);
            SteamVR_Controller.Input(
              SteamVR_Controller.GetDeviceIndex(
                  SteamVR_Controller.DeviceRelation.Rightmost)).TriggerHapticPulse(500);
        }
	}

	void Start () {
        //trackedObject = GetComponent<SteamVR_TrackedObject>();    //toggle
        //controller = GetComponent<SteamVR_TrackedController> ();   //toggle
        //controller.PadClicked += Controller_PadClicked;           //toggle

        //textMessages.text = "Welcome to your smart phone!";
        textMessages.text = textBank.s1;
        currentText = 1;
    }

	void Controller_PadClicked (object sender, ClickedEventArgs e)
	{
		if (device.GetAxis ().x != 0 || device.GetAxis ().y != 0) {
			Debug.Log (device.GetAxis ().x + " " + device.GetAxis ().y);
		}

		//Reading out x,y values to find button selected
		/*
		if (device.GetAxis ().x > 0 && device.GetAxis ().y > 0) {
			//b selected
		} else if (device.GetAxis ().x > 0 && device.GetAxis ().y < 0) {
			//c selected
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y > 0) {
			//a selected
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y < 0) {
			//d selected
		}*/

	}
    public bool vibrate;
	void Update () {
		//device = SteamVR_Controller.Input ((int)trackedObject.index);   //toggle

        //USE a,b,c,d on keyboard for testing purposes
        if (vibrate)
        {
            VibrateController();
        }

		//Josh's String Testing Below (kyler commented out for testing)
		//if (Input.GetMouseButtonDown (0)) {
		//	textMessages.text = textBank.s14;
        //}

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 14)
        {
            textMessages.text = textBank.s1;
            currentText = 1;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 13)
        {
            textMessages.text = textBank.s14;
            currentText = 14;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 12)
        {
            textMessages.text = textBank.s13;
            currentText = 13;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 11)
        {
            textMessages.text = textBank.s13;
            currentText = 13;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D)) && currentText == 10)
        {
            textMessages.text = textBank.s11;
            currentText = 11;
        }
        else if ((Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C)) && currentText == 10)
        {
            textMessages.text = textBank.s12;
            currentText = 12;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 9)
        {
            textMessages.text = textBank.s10;
            currentText = 10;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 8)
        {
            textMessages.text = textBank.s10;
            currentText = 10;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.D)) && currentText == 7)
        {
            textMessages.text = textBank.s8;
            currentText = 8;
        }
        else if (Input.GetKeyDown(KeyCode.C) && currentText == 7)
        {
            textMessages.text = textBank.s9;
            currentText = 9;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 6)
        {
            textMessages.text = textBank.s7;
            currentText = 7;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 5)
        {
            textMessages.text = textBank.s6;
            currentText = 6;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 4)
        {
            textMessages.text = textBank.s5;
            currentText = 5;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 3)
        {
            textMessages.text = textBank.s4;
            currentText = 4;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.C) || Input.GetKeyDown(KeyCode.D)) && currentText == 2)
        {
            textMessages.text = textBank.s3;
            currentText = 3;
        }

        if ((Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.C)) && currentText == 1)
        {
            textMessages.text = textBank.s2;
            currentText = 2;
        }
        else if((Input.GetKeyDown(KeyCode.B) || Input.GetKeyDown(KeyCode.D)) && currentText == 1){
            textMessages.text = textBank.s5;
            currentText = 5;
        }
        
    }
}
