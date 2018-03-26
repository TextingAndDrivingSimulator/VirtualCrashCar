using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPed : MonoBehaviour {

    private bool justHit = false;

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
            GoingOffRoadDemeritCounter.setDemerits(20);
            StartCoroutine(hitTime());
        }
    }

}
