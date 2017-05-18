using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Notes : MonoBehaviour {

	void OnTriggerEnter(Collider something){
		if (something.tag == "Note") {
			Destroy (something.gameObject); 
		}
	}


}
