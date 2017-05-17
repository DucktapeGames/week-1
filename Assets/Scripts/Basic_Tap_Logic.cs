using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic_Tap_Logic : MonoBehaviour {

	public GameObject NOTE_PREFAB; 
	public Vector3[] spawnPositions; 
	public Song_Taps song1; 


	void Awake(){
		spawnPositions = new Vector3[3];
		song1 = new Song_Taps (10f); 
		///here are the song notes you must play
		song1.taps[0,0] = false; song1.taps[0,1] = true; song1.taps[0,2] = false; //1
		song1.taps[1,0] = false; song1.taps[1,1] = true; song1.taps[1,2] = false; //1
		song1.taps[2,0] = false; song1.taps[2,1] = false; song1.taps[2,2] = false; //1
		song1.taps[3,0] = false; song1.taps[3,1] = false; song1.taps[3,2] = false; //1
		song1.taps[4,0] = false; song1.taps[4,1] = false; song1.taps[4,2] = false; //1
		song1.taps[5,0] = false; song1.taps[5,1] = false; song1.taps[5,2] = false; //1
		song1.taps[6,0] = false; song1.taps[6,1] = false; song1.taps[6,2] = false; //1
		song1.taps[7,0] = false; song1.taps[7,1] = false; song1.taps[7,2] = false; //1
		song1.taps[8,0] = false; song1.taps[8,1] = false; song1.taps[8,2] = false; //1
		song1.taps[9,0] = false; song1.taps[9,1] = false; song1.taps[9,2] = false; //1

		///here int ends
	}

	void Start(){
		StartCoroutine (launchTaps()); 
	}

	IEnumerator launchTaps(){
		while (true) {
			for (int i = 0; i < song1.songRate; i++) {
				if (song1.taps [i, 0] == true) {
					Note_Logic go=Instantiate (NOTE_PREFAB, spawnPositions [0], Quaternion.identity) as Note_Logic; 
					go.move (); 
				}
				if (song1.taps [i, 1] == true) {
					Note_Logic go=Instantiate (NOTE_PREFAB, spawnPositions [1], Quaternion.identity)as Note_Logic; 
					go.move (); 
				}
				if (song1.taps [i, 2] == true) {
					Note_Logic go=Instantiate (NOTE_PREFAB, spawnPositions [2], Quaternion.identity	) as Note_Logic; 
					go.move (); 
				}
			}

			yield return new WaitForSeconds (song1.tempo); 
		}
	}

}
