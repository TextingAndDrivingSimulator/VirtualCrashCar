using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morph : MonoBehaviour {

    public Animator anim;
    public GameObject victim;

    IEnumerator startAnim()
    {
        yield return new WaitForSeconds(15);
        anim.SetBool("open", true);
    }

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        anim.SetBool("open", false);
	}
	
	// Update is called once per frame
	void Update () {
        if (victim.activeSelf == true)
        {
            StartCoroutine(startAnim());
        }


	}
}
