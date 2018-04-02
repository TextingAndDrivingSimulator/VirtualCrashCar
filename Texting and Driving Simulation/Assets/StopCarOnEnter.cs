using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopCarOnEnter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		Debug.Log ("found car!");
		if (other.gameObject.CompareTag ("AICar")) {
			MoveObjectAlongWaypoints mover = other.gameObject.GetComponentInParent<MoveObjectAlongWaypoints> ();
			mover.paused = true;
		}
	}

	void OnTriggerExit(Collider other) {
		Debug.Log ("lost car!");
		if (other.gameObject.CompareTag ("AICar")) {
			MoveObjectAlongWaypoints mover = other.gameObject.GetComponentInParent<MoveObjectAlongWaypoints> ();
			mover.paused = false;
		}
	}
}
