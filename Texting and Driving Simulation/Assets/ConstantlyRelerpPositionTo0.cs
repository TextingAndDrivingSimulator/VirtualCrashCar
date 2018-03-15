using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstantlyRelerpPositionTo0 : MonoBehaviour {

	private Vector3 startPosition;

	// Use this for initialization
	void Start () {
		startPosition = this.transform.localPosition;
	}
	public float speed = .1f;
	// Update is called once per frame
	void Update () {
		// Will technically never go to 0, but this is an easy lerp, and is close enough.
		// Lerps should normaly be from a fixed start -> end, not a changing start -> end like in this one.
		this.transform.localPosition = Vector3.Lerp (this.transform.localPosition, startPosition, speed);
	}
}
