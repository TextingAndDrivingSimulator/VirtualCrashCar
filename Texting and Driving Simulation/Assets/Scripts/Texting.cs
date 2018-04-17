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

	private void BlankTextBank (float delay) {
		textMessages.text = "";
		lastChangedMessageTime = delay + Time.time;
		displayedMessage = false;
	}
	public float lastChangedMessageTime = 0;
	private bool displayedMessage = false;
    void Update()
    {
		myDevice = SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost));

		ResponseOption responseOption = GetOptionCurrentlyDepressedBack ();
		if (Time.time > lastChangedMessageTime) {
			
			if (!displayedMessage) {
				textMessages.text = currentTextMessage.FormattedMessage ();
				VibrateController ();
				mySource.Play();
				displayedMessage = true;
			}

			switch (responseOption) {
			case ResponseOption.OptionA:
				currentTextMessage = currentTextMessage.optionAReply;
				BlankTextBank (currentTextMessage.delay);
				break;
			case ResponseOption.OptionB:
				currentTextMessage = currentTextMessage.optionBReply;
				BlankTextBank (currentTextMessage.delay);
				break;
			case ResponseOption.OptionC:
				currentTextMessage = currentTextMessage.optionCReply;
				BlankTextBank (currentTextMessage.delay);
				break;
			case ResponseOption.OptionD:
				currentTextMessage = currentTextMessage.optionDReply;
				BlankTextBank (currentTextMessage.delay);
				break;
			}
		}
    }

}
