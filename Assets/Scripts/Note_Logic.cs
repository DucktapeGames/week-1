using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_Logic : MonoBehaviour {

	public float velocity; 
	private Rigidbody myRig; 

	void Start(){
		myRig = this.gameObject.GetComponent<Rigidbody> (); 
		myRig.velocity = Vector3.left * 15.25f; 

	}
		
}
