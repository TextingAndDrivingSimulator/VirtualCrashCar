using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockXandZPosition : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPosition = new Vector3 (0, this.transform.localPosition.y, 0);
		this.transform.localPosition = newPosition;
	}
}
