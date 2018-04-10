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

    public AudioClip myClip;
    public AudioSource mySource;
    private bool beingHandled = false;
    public int selection;

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
        
        mySource.clip = myClip;
        textMessages.text = textBank.s1;
        currentText = 0;
        selection = 0;
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
    void Update()
    {
        //device = SteamVR_Controller.Input ((int)trackedObject.index);   //toggle

        //USE a,b,c,d on keyboard for testing purposes
        if (vibrate)
        {
            VibrateController();
        }


        if (beingHandled)
        {

            //1-->A  2-->B  3-->C  4-->D

            if (currentText == 14)
            {
                if (selection == 1)
                {
                    textMessages.text = textBank.s1;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 1;
                    selection = 0;
                }
            }

            if (currentText == 13)
            {
                if (selection == 14)
                {
                    textMessages.text = textBank.s14;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 14;
                    selection = 0;
                }
            }

            if (currentText == 12)
            {
                if (selection == 13)
                {
                    textMessages.text = textBank.s13;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 13;
                    selection = 0;
                }
            }

            if (currentText == 11)
            {
                if (selection == 13)
                {
                    textMessages.text = textBank.s13;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 13;
                    selection = 0;
                }
            }

            if (currentText == 10)
            {
                if (selection == 11)
                {
                    textMessages.text = textBank.s11;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 11;
                    selection = 0;
                }
                else if (selection == 12)
                {
                    textMessages.text = textBank.s12;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 12;
                    selection = 0;
                }
            }

            if (currentText == 9)
            {
                if (selection == 10)
                {
                    textMessages.text = textBank.s10;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 10;
                    selection = 0;
                }
            }

            if (currentText == 8)
            {
                if (selection == 10)
                {
                    textMessages.text = textBank.s10;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 10;
                    selection = 0;
                }
            }

            if (currentText == 7)
            {
                if (selection == 8)
                {
                    textMessages.text = textBank.s8;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 8;
                    selection = 0;
                }
                else if (selection == 9)
                {
                    textMessages.text = textBank.s9;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 9;
                    selection = 0;
                }
            }

            if (currentText == 6)
            {
                if (selection == 7)
                {
                    textMessages.text = textBank.s7;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 7;
                    selection = 0;
                }
            }

            if (currentText == 5)
            {
                if (selection == 6)
                {
                    textMessages.text = textBank.s6;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 6;
                    selection = 0;
                }
            }

            if (currentText == 4)
            {
                if (selection == 5)
                {
                    textMessages.text = textBank.s5;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 5;
                    selection = 0;
                }
            }

            if (currentText == 3)
            {
                if (selection == 4)
                {
                    textMessages.text = textBank.s4;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 4;
                    selection = 0;
                }
            }

            if (currentText == 2)
            {
                if (selection == 3)
                {
                    textMessages.text = textBank.s3;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 3;
                    selection = 0;
                }
            }

            if (currentText == 1)
            {
                if (selection == 2)
                {
                    textMessages.text = textBank.s2;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 2;
                    selection = 0;
                }
                else if (selection == 5)
                {
                    textMessages.text = textBank.s5;
                    mySource.Play();
                    beingHandled = false;
                    currentText = 5;
                    selection = 0;
                }
            }

        }
        else
        {
            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3)) && currentText == 0)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                currentText = 1;
                selection = 2;
            }
            else if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 0)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                currentText = 1;
                selection = 5;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 2)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 3;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 3)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 4;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 4)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 5;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 5)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 6;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 6)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 7;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 7)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 8;
            }
            else if ((Input.GetKeyDown(KeyCode.Alpha3)) && currentText == 7)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 9;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 10)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 11;
            }
            else if ((Input.GetKeyDown(KeyCode.Alpha2) || (Input.GetKeyDown(KeyCode.Alpha3))) && currentText == 10)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 12;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 11)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 13;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 12)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 13;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 13)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 14;
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 14)
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                selection = 1;
            }

        }
    }

    IEnumerator Delay()
    {
        beingHandled = false;
        yield return new WaitForSeconds(5);
        beingHandled = true;
    }

}
