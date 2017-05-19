using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch_Thingies : MonoBehaviour {

	private Transform myTrans; 
	public static float offsetX; 

	void Awake(){
		Player_Score_Life.LIFE = 100f; 
		Player_Score_Life.SCORE = 0; 
		myTrans = this.gameObject.transform; 
	}


	void OnTriggerEnter(Collider something){
		if (something.tag == "Note") {
			Player_Score_Life.SCORE+=2;
			Player_Score_Life.LIFE = Mathf.Clamp (Player_Score_Life.LIFE + 1, 0, 100); 
			Destroy (something.gameObject); 
			offsetX = Mathf.Clamp (0, -4f, transform.position.x + (100f / Player_Score_Life.LIFE)); 
			myTrans.position = new Vector3 (offsetX, transform.position.y, transform.position.z);    
		}
		else if (something.tag == "Obstacle") {
			Player_Score_Life.LIFE = Mathf.Clamp (Player_Score_Life.LIFE - 2, 0, 100); 
			Player_Score_Life.SCORE--;
			Destroy (something.gameObject);
			offsetX = Mathf.Clamp (0, -4f, transform.position.x - (100f/Player_Score_Life.LIFE)); 

			myTrans.position = new Vector3 (offsetX, transform.position.y, transform.position.z);    
		}

		Debug.Log (Player_Score_Life.LIFE + " " + Player_Score_Life.SCORE + "WITH OFFSET: " + offsetX); 

	}




}
