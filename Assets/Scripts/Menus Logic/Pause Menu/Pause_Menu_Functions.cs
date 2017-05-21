using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Pause_Menu_Functions : MonoBehaviour {


	public AudioSource boombox; 
	public GameObject pauseMenu; 


	public void Continue(){

		Time.timeScale = 1; 
		boombox.UnPause(); 
		pauseMenu.SetActive (false); 

	}

	public void Restart(){
		SceneManager.LoadScene (1); 
	}

	public void Menu(){
		SceneManager.LoadScene (0); 
	}

}
