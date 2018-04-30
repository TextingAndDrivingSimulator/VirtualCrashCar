using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitFemale : MonoBehaviour
{
    private bool justHit = false;
    private bool notHit = true;
    public Text PedHit;
	private AudioSource ouch;
	public GameObject cartoonCar;
    public UnityStandardAssets.Vehicles.Car.CarController bob;

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
				CreditManager.victimNumbers.Add (1);
                notHit = false;
            }

            ouch.Play ();
            GoingOffRoadDemeritCounter.setDemerits(20);

            float speed = bob.CurrentSpeed;

            GetComponent<CharacterController>().enabled = false;
            this.GetComponent<Animator>().enabled = false;
            GetComponent<rotate180>().enabled = false;

            GetComponent<CapsuleCollider>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = false;

            GetComponent<Rigidbody>().AddForce(bob.transform.forward * (speed));
            GetComponent<Rigidbody>().useGravity = true;
            GetComponent<CapsuleCollider>().enabled = true;

            StartCoroutine(flashTime(3, PedHit)); //Change the first parameter of flashTime to change the amount of time the text is on.
            StartCoroutine(hitTime());
        }
    }

}
