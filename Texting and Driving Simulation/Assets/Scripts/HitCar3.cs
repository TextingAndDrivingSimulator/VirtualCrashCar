using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitCar3 : MonoBehaviour
{

    public GameObject userCar;
    private AudioSource crash;
    public Text CarHit;
    private bool justHitCar = false;
    private bool notHit = true;

    private void Start()
    {
        CarHit.enabled = false;
        crash = userCar.GetComponent<AudioSource>();
    }

    IEnumerator flashTime(float time, Text text)
    {
        text.enabled = true;
        yield return new WaitForSeconds(time);
        text.enabled = false;
    }

    IEnumerator hitTimeCar() //Makes sure dermerits aren't constantly added for 1 colission.
    {
        justHitCar = true;
        yield return new WaitForSeconds(3);
        justHitCar = false;
    }

    public void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player" && justHitCar == false)
        {
            if (notHit)
            {
                CreditManager.victimNumbers.Add(4);
                notHit = false;
            }
            crash.Play();
            GoingOffRoadDemeritCounter.setDemerits(10);
            StartCoroutine(flashTime(3, CarHit)); //Change the first parameter of flashTime to change the amount of time the text is on.
            StartCoroutine(hitTimeCar());
        }
    }

}
