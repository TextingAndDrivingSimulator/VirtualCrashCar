using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//****************** CITATION *********************************
//Inspiration for demerit display drawn from tutorial on Unity Website
//"Displaying the Score and Text" by Unity
//https://unity3d.com/learn/tutorials/projects/roll-ball-tutorial/displaying-score-and-text
//*************************************************************

public class DemeritCount : MonoBehaviour {

	public Text demeritCount;
	int count;

	 void Start () {
		demeritCount.text = "Demerits: 0";
		count = 0;
	}

	 void Update () {
		//Whenever user hits object, update count appropriately



		//Below is just an example to show that the count works
		//You could just click your mouse while running in play mode
		//if (Input.GetMouseButtonDown (0)) {
		//	count++;
		//}


		//Display new count
		demeritCount.text = "Demerits: " + (GoingOffRoadDemeritCounter.getDemerits () + count) .ToString();
	}
}
