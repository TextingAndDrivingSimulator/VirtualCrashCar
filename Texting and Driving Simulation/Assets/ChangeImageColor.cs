using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeImageColor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Image>().color = Color.black;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
