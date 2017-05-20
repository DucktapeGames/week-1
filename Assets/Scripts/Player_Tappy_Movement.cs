using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Tappy_Movement : MonoBehaviour {

	public KeyCode up, down; 
	private bool bup, bdown;
	public float hold1, hold2;  
	private Transform myTrans; 

	void Awake(){
		myTrans = this.GetComponent<Transform> (); 
	}


	void FixedUpdate(){
		//picas ad
		if (Input.GetKeyDown (up) && Input.GetKeyDown (down)) {
			myTrans.position = new Vector3 (Touch_Thingies.offsetX , transform.position.y, transform.position.z);    
		}


		//picas a
		else if (Input.GetKeyDown (up) && transform.position.y < hold1) {
			myTrans.position = new Vector3 (Touch_Thingies.offsetX , transform.position.y + hold1, transform.position.z);    
		}

		//picas d
		else if(Input.GetKeyDown(down)&&transform.position.y>hold2){
			myTrans.position = new Vector3 (Touch_Thingies.offsetX , transform.position.y + hold2, transform.position.z);    
			 
		}

	}
}
