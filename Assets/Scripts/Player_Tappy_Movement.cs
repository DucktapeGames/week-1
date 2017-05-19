using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Tappy_Movement : MonoBehaviour {

	public KeyCode up, middle, down; 
	private bool bup, bmiddle, bdown;
	public float hold1, hold2;  
	private Transform myTrans; 

	void Awake(){
		myTrans = this.GetComponent<Transform> (); 
	}


	void Update(){
		if (Input.GetKeyDown (up) && transform.position.y < hold1) {
			myTrans.position = new Vector3 (transform.position.x, hold1, transform.position.z);    
		}else if(Input.GetKeyDown(middle)){
			myTrans.position = new Vector3 (transform.position.x, 0, transform.position.z);    
			   
		}else if(Input.GetKeyDown(down)&&transform.position.y>hold2){
			myTrans.position = new Vector3 (transform.position.x, hold2, transform.position.z);    
			 
		}

	}
}
