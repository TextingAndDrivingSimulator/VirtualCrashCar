using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwapImageOnHover : MonoBehaviour {
	public Sprite noHover;
	public Sprite hover;

	private Image image;
	// Use this for initialization
	void Start () {
		image = this.GetComponent<Image> ();
	}
	


	public void gainFocus() {
		image.sprite = hover;
	}

	public void loseFocus() {
		image.sprite = noHover;
	}
}
