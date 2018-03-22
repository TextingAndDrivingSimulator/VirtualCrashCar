using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnWheel : MonoBehaviour {
//****************** CITATION *********************************
//Inspiration for wheel turning drawn from post on Unity forums
//https://answers.unity.com/questions/1106170/how-to-make-a-functional-steering-wheel-for-a-car.html
//*************************************************************
	public int turnSpeed;
	public GameObject wheel;

	float rotations = 0;
	Quaternion defaultRotation;

	void Start()
	{
		defaultRotation = wheel.transform.localRotation;
	}

	void Update()
	{
		if(Input.GetKey (KeyCode.A)) //change to detect rotation position of wheel on x-axis
		{

			wheel.transform.Rotate(-Vector3.up * Time.deltaTime * turnSpeed);
			rotations -= turnSpeed;
		}

		else if(Input.GetKey (KeyCode.D)) //change to detect rotation position of wheel on x-axis
		{

			wheel.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
			rotations += turnSpeed;
		}
		else    //rotate to default
		{
			if (rotations < -1)
			{
				wheel.transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed);
				rotations += turnSpeed;
			}
			else if (rotations > 1)
			{
				wheel.transform.Rotate(-Vector3.up * Time.deltaTime * turnSpeed);
				rotations -= turnSpeed;
			}
			else if (rotations != 0)
			{
				wheel.transform.localRotation = defaultRotation;
				rotations = 0;
			}
		}
	}

}
