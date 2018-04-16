using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitMale2 : MonoBehaviour
{
    private bool justHit = false;
    private bool notHit = true;
    public Text PedHit;
	private AudioSource ouch;
	public GameObject cartoonCar;

    private void Start()
    {
        PedHit.enabled = false;
		ouch = cartoonCar.GetComponent<AudioSource>();
    }

    IEnumerator flashTime(float time, Text text)
    {
        text.enabled = true;
        yield return new WaitForSeconds(time);
        text.enabled = false;
    }

    IEnumerator hitTime()
    {
        justHit = true;
        yield return new WaitForSeconds(3);
        justHit = false;
    }

    public void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player" && justHit == false)
        {
            if (notHit)
            {
                CreditManager.victimNumbers.Add(6);
                notHit = false;
            }
			ouch.Play ();
            GoingOffRoadDemeritCounter.setDemerits(20);
            StartCoroutine(flashTime(3, PedHit)); //Change the first parameter of flashTime to change the amount of time the text is on.
            StartCoroutine(hitTime());
        }
    }

}
