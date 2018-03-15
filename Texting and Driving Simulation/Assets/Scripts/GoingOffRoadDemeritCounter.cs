using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingOffRoadDemeritCounter : MonoBehaviour {
	private static int demerits;
	public int increaseDemeritScore = 10;

	public static int getDemerits() {
		return demerits;
	}

	private bool playerInside = false;
	public void OnTriggerEnter(Collider c) {
		
		if (c.CompareTag ("Player") && !playerInside) {
			demerits += increaseDemeritScore;
			playerInside = true;
		}
	}

	public void OnTriggerExit(Collider c) {
		playerInside = false;
	}

}
