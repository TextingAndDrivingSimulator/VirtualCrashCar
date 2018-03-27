using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitCar : MonoBehaviour
{

    private bool justHitCar = false;

    IEnumerator hitTimeCar()
    {
        justHitCar = true;
        yield return new WaitForSeconds(3);
        justHitCar = false;
    }

    public void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Player" && justHitCar == false)
        {
            GoingOffRoadDemeritCounter.setDemerits(10);
            StartCoroutine(hitTimeCar());
        }
    }

}
