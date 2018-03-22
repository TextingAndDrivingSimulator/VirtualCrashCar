using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnWheelUpdated : MonoBehaviour {

	public float smooth = 2.0F;
	public float tiltAngle = 60.0F;

	void Update () {
		//FIX LOCAL XYZ POSITION

		//Vector3 newPosition = new Vector3 (-0.406f, -0.119f, -3.54f);
		//transform.localPosition = newPosition;

		//Is this how I lock rotation about y and z?
		//this.transform.localRotation = Quaternion.Euler(0,x,0);

		//this.transform.localRotation.y = -90;
		//this.transform.localRotation.z = 0;


		//FIX LOCAL YZ ROTATION
		float tiltAroundX = Input.GetAxis("Horizontal") * tiltAngle;
		Quaternion target = Quaternion.Euler(tiltAroundX, 0 , 0); //is the order z, x, y?
		this.transform.localRotation = Quaternion.Slerp(this.transform.localRotation, target, Time.deltaTime * smooth);

	}
}
