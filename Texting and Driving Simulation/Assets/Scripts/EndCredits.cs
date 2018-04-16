using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCredits : MonoBehaviour {
	public Text finalScoreText;
	public GameObject finalScore;
	public GameObject demeritCountText;
   
	public GameObject femalePic1;
    public GameObject carPic1;
    public GameObject carPic2;
    public GameObject carPic3;
    public GameObject malePic1;
    public GameObject malePic2;
    public GameObject carPic4;
    public GameObject carPic5;


    void printStory()
    {
        if (CreditManager.victims.Count == 0) //Pick from noVic if nothing has been hit
        {
            int story = Random.Range(0, CreditManager.noVic.Count - 1);
            CreditManager.noVic[story].SetActive(true);
        }
        else {
            int story = Random.Range(0, CreditManager.victims.Count - 1);
            CreditManager.victims[story].SetActive(true);
        }

    }

   
	void Start () {
        CreditManager.noVic.Add(femalePic1); //Will add more as more stories are added (same thing with the cases in addToVictims)
		CreditManager.noVic.Add(carPic1);
		CreditManager.noVic.Add(carPic2);
		CreditManager.noVic.Add(carPic3);
        CreditManager.noVic.Add(malePic1);
        CreditManager.noVic.Add(malePic2);
        CreditManager.noVic.Add(carPic4);
        CreditManager.noVic.Add(carPic5);
		StartCoroutine(Credits());
		foreach ( int i in CreditManager.victimNumbers ) {
			this.addToVictims (i);
		}
	}
		
	public void addToVictims(int h)
	{
		GameObject v = null; 
		switch (h) //The scripts of the victims will set h, corresponding to which type of victim was hit.
		{
		case 1:
			v = femalePic1;
			break;
		case 2:
			v = carPic1;
			break;
		case 3:
			v = carPic2;
			break;
		case 4:
			v = carPic3;
			break;
        case 5:
            v = malePic1;
            break;
        case 6:
            v = malePic2;
            break;
        case 7:
            v = carPic4;
            break;
        case 8:
            v = carPic5;
            break;
		}
        CreditManager.victims.Add(v);
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
        printStory();
		
	}
		
}
