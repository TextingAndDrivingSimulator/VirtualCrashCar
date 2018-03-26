using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingOffRoadDemeritCounter : MonoBehaviour {
	private static int demerits;
	public int increaseDemeritScore = 10;

	public static int getDemerits() {
		return demerits;
	}

    public static void setDemerits(int add)
    {
        demerits += add;
    }

	private static bool playerInside = false;
    static int leave = 0;
	public void OnTriggerEnter(Collider c) {
		
		if (c.CompareTag ("Player") && !playerInside && leave == 0) {
			demerits += increaseDemeritScore;
			playerInside = true;
        
		}
        leave += 1;
    }

	public void OnTriggerExit(Collider c) {
		playerInside = false;
        leave -= 1;
	}

}
