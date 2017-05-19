using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit_Keys_Logic : MonoBehaviour {

	public KeyCode myKey; 
	public bool okToHit; 
	private GameObject go; 

	void Start(){
		okToHit = false;  
	}

	void FixedUpdate(){

		if (okToHit && Input.GetKey (myKey)) {
			okToHit = false; 
			Destroy (go.gameObject); 
		}

	}

	void OnTriggerStay(Collider something){
		if (something.tag == "Note") {
			okToHit = true;  
			go = something.gameObject; 
		}
	}

	void OnTriggerExit(Collider something){
		okToHit = false; 
	}


}
