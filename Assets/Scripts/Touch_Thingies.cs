using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Thingies : MonoBehaviour {


	void Awake(){
		Player_Score_Life.LIFE = 100f; 
		Player_Score_Life.SCORE = 0; 
	}


	void OnTriggerEnter(Collider something){
		if (something.tag == "Note") {
			Player_Score_Life.SCORE+=2;
			Player_Score_Life.LIFE = Mathf.Clamp (Player_Score_Life.LIFE + 1, 0, 100); 
			Destroy (something.gameObject); 
		}
		if (something.tag == "Obstacle") {
			Player_Score_Life.LIFE = Mathf.Clamp (Player_Score_Life.LIFE - 2, 0, 100); 
			Player_Score_Life.SCORE--;
			Destroy (something.gameObject); 
		}

		Debug.Log (Player_Score_Life.LIFE + " " + Player_Score_Life.SCORE); 
	}




}
