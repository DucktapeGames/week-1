﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Settings_Menu : MonoBehaviour {

	public Slider VolumeSlider;
	public Settings SettingsRef;

	// Use this for initialization
	void Start () {
		VolumeSlider.value = SettingsRef.Volume;
	}
}
