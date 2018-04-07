using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCredits : MonoBehaviour {
	public Text finalScoreText;
	public GameObject finalScore;
	public GameObject demeritCountText;
    private static List<GameObject> victims = new List<GameObject>(); //List of Objects hit.
    private static List<GameObject> noVic = new List<GameObject>();  //List of all Victims (it says noVic because it means no victim has been hit)
	public static GameObject femalePic1;
    public static GameObject carPic1;
    public static GameObject carPic2;
    public static GameObject carPic3;


    void printStory()
    {
        if (victims.Count == 0) //Pick from noVic if nothing has been hit
        {
            int story = Random.Range(0, noVic.Count);
            noVic[story].SetActive(true);
        }
        else {
            var story = Random.Range(0, victims.Count);
            victims[story].SetActive(true);
        }

    }

    public static void addToVictims(int h)
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
        }
        int i = victims.Count;
        victims[i] = v;
    }

	void Start () {
        noVic.Add(femalePic1); //Will add more as more stories are added (same thing with the cases in addToVictims)
        noVic.Add(carPic1);
        noVic.Add(carPic2);
        noVic.Add(carPic3);
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
        printStory();
		
	}
		
}
