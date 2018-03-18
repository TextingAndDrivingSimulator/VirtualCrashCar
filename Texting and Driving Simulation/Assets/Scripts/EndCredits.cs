using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCredits : MonoBehaviour {
	public Text finalScoreText;

	public GameObject finalScore;
	public GameObject demeritCountText;
	public GameObject femalePic1;
	public GameObject femaleText1;


	void Start () {
		StartCoroutine(Credits());
	}

	IEnumerator Credits () {
		finalScore.SetActive (true);
		demeritCountText.SetActive (true);

		//just use all return functions for individual scores and add here
		finalScoreText.text = "Demerits: " + (GoingOffRoadDemeritCounter.getDemerits ()) .ToString();

		yield return new WaitForSeconds(5); //Use this for gaps between slides
		//set slides active and not active
		//use if-statements for choosing specific slides
		finalScore.SetActive (false);
		demeritCountText.SetActive (false);
		femalePic1.SetActive (true);
		femaleText1.SetActive (true);
	}
		
}
