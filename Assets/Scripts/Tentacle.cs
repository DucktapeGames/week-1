using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Animator))]
public class Tentacle : MonoBehaviour {

	Animator mAnimator;
	// Use this for initialization
	void Start () {
		mAnimator = GetComponent<Animator> ();
		mAnimator.Play("idle", -1, Random.Range(0f, 1f));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
