using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note_Logic : MonoBehaviour {


	IEnumerator StartMoving(int rate){
		while (true) {
			this.transform.Translate (Vector3.left * rate); 
			yield return new WaitForSeconds (Time.fixedDeltaTime); 
		}
	}

	public void move(){
		StartCoroutine (StartMoving ()); 
	}

	public void stop(){
		StopCoroutine (StartMoving ()); 
	}
}
