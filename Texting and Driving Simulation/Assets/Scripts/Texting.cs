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
    private bool soundPlayed = false;
    private bool pressed = false;

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

        //Josh's String Testing Below (kyler commented out for testing)
        //if (Input.GetMouseButtonDown (0)) {
        //	textMessages.text = textBank.s14;
        //}


        if (beingHandled)
        {

            //1-->A  2-->B  3-->C  4-->D
            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 14)
            {
                //StartCoroutine(Delay());            // waits for 5 seconds before next input can be accepted
                textMessages.text = textBank.s1;
                currentText = 1;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 13)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s14;
                currentText = 14;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 12)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s13;
                currentText = 13;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 11)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s13;
                currentText = 13;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 10)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s11;
                currentText = 11;
                mySource.Play();
            }
            else if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3)) && currentText == 10)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s12;
                currentText = 12;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 9)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s10;
                currentText = 10;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 8)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s10;
                currentText = 10;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 7)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s8;
                currentText = 8;
                mySource.Play();
            }
            else if (Input.GetKeyDown(KeyCode.Alpha3) && currentText == 7)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s9;
                currentText = 9;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 6)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s7;
                currentText = 7;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 5)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s6;
                currentText = 6;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 4)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s5;
                currentText = 5;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 3)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s4;
                currentText = 4;
                mySource.Play();
            }

            if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 2)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s3;
                currentText = 3;
                mySource.Play();
            }

            if (currentText == 1)
            {
                if (!soundPlayed)
                {
                    textMessages.text = textBank.s2;
                    mySource.Play();
                    soundPlayed = true;
                    beingHandled = false;
                    currentText = 2;
                }

                /*if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3)))
                {
                    textMessages.text = textBank.s2;
                    currentText = 2;
                    //pressed = true;
                }
                else if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha4)))
                {
                    textMessages.text = textBank.s5;
                    currentText = 5;
                    //pressed = true;
                }*/
            }

            /*if ((Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha3)) && currentText == 1)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s2;
                currentText = 2;
                mySource.Play();
            }
            else if ((Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha4)) && currentText == 1)
            {
                //StartCoroutine(Delay());
                textMessages.text = textBank.s5;
                currentText = 5;
                mySource.Play();
            }*/
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Alpha4))
            {
                textMessages.text = textBank.s0;
                StartCoroutine(Delay());
                currentText = 1;
                //pressed = false;
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
