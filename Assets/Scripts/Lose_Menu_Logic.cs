using System.Collections;
 using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Lose_Menu_Logic : MonoBehaviour {

	public Pause pauseLogicObject;
	public GameObject loseScree; 
	public Transform player; 

	public Text scoreText;

	int finalScore;

	void StartLoseSequence() {
		pauseLogicObject.enabled = false;
		finalScore = (int)Player_Score_Life.SCORE;
		loseScree.SetActive (true);
		scoreText.text = "" + finalScore;
	}

	void Update() {
		if (player.position.x <=-32f) {
			StartLoseSequence (); 
		}
	}
}
