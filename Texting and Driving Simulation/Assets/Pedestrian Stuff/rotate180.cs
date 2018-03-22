using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate180 : MonoBehaviour {

    public float distance1;
    public float distance2;
    public bool flip;

	// Use this for initialization
	void Start () {
        distance1 = transform.position.x;
        distance2 = transform.position.x;
        flip = true;
    }
	
	// Update is called once per frame
	void Update () {
        //(transform.position.x <= -350 && transform.position.z <= 2084.64)
        if (flip) { distance2 = transform.position.x; }

        if ((distance1 - distance2 > 5 || distance2 - distance1 > 5) && distance2 < -346) // positon value we want to rotate character
        {
            transform.localRotation *= Quaternion.Euler(0, 180, 0);
            distance2 = distance2+1;
            flip = false;
        }
        else if((distance1 - distance2 > 5 || distance2 - distance1 > 5) && distance2 > -346)
        {
            transform.localRotation *= Quaternion.Euler(0, 180, 0);
            distance2 = distance2 - 1;
            flip = !flip;
        }
    }
}
