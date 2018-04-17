using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Texting : MonoBehaviour {
	public Text textMessages;
	public TextBank textBank = new TextBank ();

	//****************** CITATION *********************************
	//Inspiration for reading Vive trackpad input from YouTube Tutorial
	//"Unity VR: Vive Touchpad Input Mapping Tutorial(SteamVR)" by Leading Ones
	//https://www.youtube.com/watch?v=Awr52z9Y670
	//*************************************************************

    private SteamVR_Controller.Device myDevice;

	public bool enableVRControls = false;

    public AudioClip myClip;
    public AudioSource mySource;

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
        //mySource = GetComponent<AudioSource>();
        //mySource.Play();
        //yield return new WaitForSeconds(mySource.clip.length);
		textBank.Start();
        mySource.clip = myClip;
		Debug.Log ("Start() is a go");
		currentTextMessage = textBank.getStartingMessage ();
    }

	void Controller_PadClicked (object sender, ClickedEventArgs e)
	{
		if (myDevice.GetAxis ().x != 0 || myDevice.GetAxis ().y != 0) {
			Debug.Log (myDevice.GetAxis ().x + " " + myDevice.GetAxis ().y);
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

	private ResponseOption GetOptionCurrentlyDepressedBack() {
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			return ResponseOption.OptionA;
		}
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			return ResponseOption.OptionB;
		}
		if (Input.GetKeyDown (KeyCode.Alpha3)) {
			return ResponseOption.OptionC;
		}
		if (Input.GetKeyDown (KeyCode.Alpha4)) {
			return ResponseOption.OptionD;
		}

		if (myDevice == null) {
			Debug.Log ("No vive controller detected!");
			return ResponseOption.NoOption;
		}

		if (myDevice.GetAxis().x < 0 && myDevice.GetAxis().y > 0) {
			return ResponseOption.OptionA;
		}
		if (myDevice.GetAxis ().x > 0 && myDevice.GetAxis ().y > 0) {
			return ResponseOption.OptionB;
		}
		if (myDevice.GetAxis ().x > 0 && myDevice.GetAxis ().y < 0) {
			return ResponseOption.OptionC;
		}
		if (myDevice.GetAxis ().x < 0 && myDevice.GetAxis ().y < 0) {
			return ResponseOption.OptionD;
		}

		return ResponseOption.NoOption;
	}

	private TextMessage currentTextMessage;

    public bool vibrate;
    void Update()
    {
		myDevice = SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost));

		ResponseOption responseOption = GetOptionCurrentlyDepressedBack ();

		switch(responseOption) {
		case ResponseOption.OptionA:
			currentTextMessage = currentTextMessage.optionAReply;
			break;
		case ResponseOption.OptionB:
			currentTextMessage = currentTextMessage.optionBReply;
			break;
		case ResponseOption.OptionC:
			currentTextMessage = currentTextMessage.optionCReply;
			break;
		case ResponseOption.OptionD:
			currentTextMessage = currentTextMessage.optionDReply;
			break;
        }
		Debug.Log ("currentTextMessage is " + (currentTextMessage==null));
		Debug.Log ("currentTextMessage is " + textMessages.text);
		textMessages.text = currentTextMessage.messageContent;
    }

}
