using UnityEngine;
using System.Collections;

public class CrashBox : MonoBehaviour {
	public BoxCollider2D boxEdge;
	public GameObject panel;

	// Use this for initialization
	void Start () {
		boxEdge = GetComponent<BoxCollider2D>();
		boxEdge.enabled= true;
	}

	// Update is called once per frame
	void Update () {
		if(boxEdge.IsTouchingLayers()){
			panel.SetActive (true);
			Time.timeScale = 0;//pause
		}
	}
}
