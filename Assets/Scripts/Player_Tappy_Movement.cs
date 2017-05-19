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
		//pias asd
		if (Input.GetKeyDown (middle) && Input.GetKeyDown (down) && Input.GetKeyDown(up)) {
			myTrans.position = new Vector3 (transform.position.x, 0, transform.position.z);    
		}
		//picas ad
		else if (Input.GetKeyDown (up) && Input.GetKeyDown (down)) {
			myTrans.position = new Vector3 (transform.position.x, hold1, transform.position.z);    
		}
		//picas sd
		else if (Input.GetKeyDown (middle) && Input.GetKeyDown (up)) {
			myTrans.position = new Vector3 (transform.position.x, 0, transform.position.z);    
		}
		//picas as
		else if (Input.GetKeyDown (middle) && Input.GetKeyDown (down)) {
			myTrans.position = new Vector3 (transform.position.x, 0, transform.position.z);    
		}
		//picas a
		else if (Input.GetKeyDown (up) && transform.position.y < hold1) {
			myTrans.position = new Vector3 (transform.position.x, hold1, transform.position.z);    
		}
		//picas d
		else if(Input.GetKeyDown(middle)){
			myTrans.position = new Vector3 (transform.position.x, 0, transform.position.z);       
		}
		//picas d
		else if(Input.GetKeyDown(down)&&transform.position.y>hold2){
			myTrans.position = new Vector3 (transform.position.x, hold2, transform.position.z);    
			 
		}

	}
}
