using UnityEngine;
public class Song_Taps {

	public float tempo; 
	public float songDuration;
	private int _songRate; 
	public bool[,] taps; 
	public int songRate{
		get{
			return _songRate; 
		}
	}

	public Song_Taps(float tempo){
		_songRate = Mathf.RoundToInt(songDuration /tempo);
		taps = new bool[_songRate, 3]; 
	}


}
