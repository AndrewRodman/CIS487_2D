﻿using UnityEngine;
using System.Collections;

public class OpenHowToPlayWindow : MonoBehaviour {
	public GameObject panel;
	public static bool on;
	// Use this for initialization
	void Start () {
		on = false;
	}

	// Update is called once per frame
	void Update () {
		if (on ==false) {
			panel.SetActive (false);

		}
		if (on ==true) {
			panel.SetActive (true);

		}
	}

	public void Clicked(){
		if (on == false) {
			
			on = true;
		} else {
			
			on = false;
		}
	}
}
