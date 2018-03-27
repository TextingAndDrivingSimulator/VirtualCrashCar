using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoingOffRoadDemeritCounter : MonoBehaviour {
	private static int demerits;
	public int increaseDemeritScore = 10;
    private static bool playerInside = false;
    static int leave = 0;

    public static int getDemerits() {
		return demerits;
	}

    public static void setDemerits(int add)
    {
        demerits += add;
    }

	
	public void OnTriggerEnter(Collider c) {
		
		if (c.CompareTag ("Player") && !playerInside /*&& leave == 0*/) {
			demerits += increaseDemeritScore;
			playerInside = true;
        
		}
        if (c.CompareTag("Player"))
        {
            leave += 1;
        }
    }

	public void OnTriggerExit(Collider c) {
        if (c.CompareTag("Player"))
        {
            playerInside = false;
            leave -= 1;
        }
	}

}
