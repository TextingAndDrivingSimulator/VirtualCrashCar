using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantlyRelerpRotationTo0 : MonoBehaviour {
	private Quaternion startRotation;

	// Use this for initialization
	void Start () {
		startRotation = this.transform.localRotation;
	}
	public float speed = .1f;
	// Update is called once per frame
	void Update () {
		// Will technically never go to 0, but this is an easy lerp, and is close enough.
		// Lerps should normaly be from a fixed start -> end, not a changing start -> end like in this one.
		this.transform.localRotation = Quaternion.Lerp (this.transform.localRotation, startRotation, speed);
	}
}
