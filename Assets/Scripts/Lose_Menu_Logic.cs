using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose_Menu_Logic : MonoBehaviour {

	public Pause pauseLogicObject;
	public GameObject loseScree; 
	public Transform player; 


	void StartLoseSequence(){
		pauseLogicObject.enabled = false; 
		loseScree.SetActive (true); 
	}

	void Update(){
		if (player.position.x <=-35f) {
			StartLoseSequence (); 
		}
	}



}
