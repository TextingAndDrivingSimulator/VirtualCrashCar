using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate180 : MonoBehaviour {

    public float distance1;
    public float distance2;
    public int stopPoint;

	// Use this for initialization
	void Start () {
        distance1 = transform.position.x;
        distance2 = transform.position.x;
    }
	
	// Update is called once per frame
	void Update () {

        distance2 = transform.position.x;

        if ((distance1 - distance2 > 5 || distance2 - distance1 > 5) && distance2 < stopPoint) // positon value we want to rotate character
        {
            transform.localRotation *= Quaternion.Euler(0, 180, 0);
            distance2 = distance2+1;
        }
        else if((distance1 - distance2 > 5 || distance2 - distance1 > 5) && distance2 > stopPoint)
        {
            transform.localRotation *= Quaternion.Euler(0, 180, 0);
            distance2 = distance2 - 1;
        }
    }
}
