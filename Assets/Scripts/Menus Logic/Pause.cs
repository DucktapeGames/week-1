﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {

	public AudioSource boombox; 
	public GameObject pauseMenu; 

	void Awake(){
		
	}
		
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Time.timeScale = 0; 
			boombox.Pause ();
			pauseMenu.SetActive (true);  
		}

	}
}
