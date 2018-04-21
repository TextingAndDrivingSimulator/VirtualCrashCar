using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitMale1 : MonoBehaviour
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
                CreditManager.victimNumbers.Add(5);
                notHit = false;
            }
			ouch.Play ();
            GoingOffRoadDemeritCounter.setDemerits(20);

            // THIS IS WHERE TO ADD PEDESTRIAN PHYSICS

            // (1) Stop 'walking' Animation from playing
            //     switch to idle "default" mode
            //     just add a condition in transitions
            //      in animator window

            // (2) Get the direction of where pedestrian was hit ..?
            // this would be 'transform.forward' below ....?

            // (3) Apply force to pedestrian (need rigidbody component for this part)
            //GetComponent<Rigidbody>().AddForce(transform.forward * 500);
            //GetComponent<Rigidbody>().useGravity = true;
            
            //////////////////////////////////////////

            StartCoroutine(flashTime(3, PedHit)); //Change the first parameter of flashTime to change the amount of time the text is on.
            StartCoroutine(hitTime());
        }
    }

}
