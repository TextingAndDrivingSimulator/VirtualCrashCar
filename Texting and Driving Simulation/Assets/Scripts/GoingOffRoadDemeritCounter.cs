using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoingOffRoadDemeritCounter : MonoBehaviour {
	private static int demerits;
	public int increaseDemeritScore = 10;
    private static bool playerInside = false;
    static int leave = 0;
    public Text OffRoad;

    private void Start()
    {
        OffRoad.enabled = false;
    }

    public static int getDemerits() {
		return demerits;
	}

    public static void setDemerits(int add)
    {
        demerits += add;
    }

    IEnumerator flashTime(float time, Text text)
    {
        text.enabled = true;
        yield return new WaitForSeconds(time);
        text.enabled = false;
    }
	
	public void OnTriggerEnter(Collider c) {
		
		if (c.CompareTag ("Player") && !playerInside && leave == 0) {
			demerits += increaseDemeritScore;
			playerInside = true;
            StartCoroutine(flashTime(3, OffRoad)); //Change the first parameter of flashTime to change the amount of time the text is on.

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
