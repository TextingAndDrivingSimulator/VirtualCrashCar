using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Morph : MonoBehaviour {

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public GameObject victim;
    public Animator animator;

    IEnumerator morph()
    {
        yield return new WaitForSeconds(3);
        animator.SetBool("open",false);
    }

	void Update () {
		if(victim.activeSelf == true)
        {
            StartCoroutine(morph());
        }
	}
}
