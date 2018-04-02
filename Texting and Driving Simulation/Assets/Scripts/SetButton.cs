using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetButton : MonoBehaviour {
	private SteamVR_TrackedObject trackedObject;
	private SteamVR_Controller.Device device;

	private SteamVR_TrackedController controller;

	Image textButtons;
	public Sprite choiceA;
	public Sprite choiceB;
	public Sprite choiceC;
	public Sprite choiceD;
	public Sprite noneChosen;

	void Start () {
		textButtons = GetComponent<Image> ();
		//trackedObject = GetComponent<SteamVR_TrackedObject>();    //toggle
		//controller = GetComponent<SteamVR_TrackedController> ();   //toggle
		//controller.PadClicked += Controller_PadClicked;           //toggle
	}

	public void setChoiceA(){
		textButtons.sprite = choiceA;
	}

	public void setChoiceB(){
		textButtons.sprite = choiceB;
	}

	public void setChoiceC(){
		textButtons.sprite = choiceC;
	}

	public void setChoiceD(){
		textButtons.sprite = choiceD;
	}

	public void setNoneChosen(){
		textButtons.sprite = noneChosen;
	}

	void Update () {
		//device = SteamVR_Controller.Input ((int)trackedObject.index);   //toggle


		//TOGGLE BELOW
		/*
		//Highlight buttons when thumb is over them
		if (device.GetAxis ().x > 0 && device.GetAxis ().y > 0) {
			//Highlight B
			setChoiceB();
		} else if (device.GetAxis ().x > 0 && device.GetAxis ().y < 0) {
			//Highlight C
			setChoiceC();
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y > 0) {
			//Highlight A
			setChoiceA();
		} else if (device.GetAxis ().x < 0 && device.GetAxis ().y < 0) {
			//Highlight D
			setChoiceD();
		} else {
			//None Chosen
			setNoneChosen();
		}*/



		//Josh's Testing Below
		/*
		if (Input.GetKeyDown ("a")) {
			setChoiceA ();
		} else if (Input.GetKeyDown ("b")) {
			setChoiceB ();
		} else if (Input.GetKeyDown ("c")) {
			setChoiceC ();
		} else if (Input.GetKeyDown ("d")) {
			setChoiceD ();
		} else {
			setNoneChosen ();
		}*/

	}

}
