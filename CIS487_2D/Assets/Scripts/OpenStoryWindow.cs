using UnityEngine;
using System.Collections;

public class OpenStoryWindow : MonoBehaviour {
	public GameObject panel;
	public static bool on;

	// Use this for initialization
	void Start () {
		on = true;
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

}
