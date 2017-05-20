using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Notes : MonoBehaviour {
	// Destroys notes and obstacles when reaching the end of the screen
	void OnTriggerEnter(Collider something) {
		if (something.tag == "Note" || something.tag == "Obstacle") {
			/*
			if (something.tag == "Note") {
				Play note anim
			}
			else {
				Play Obstacle anim explosion
			}
			*/
			Destroy (something.gameObject); 
		}
	}
}
