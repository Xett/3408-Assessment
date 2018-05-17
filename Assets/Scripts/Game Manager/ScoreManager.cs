using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	public static int score;
	Text scoreString;
	private bool scoreShown;

	void Awake() {
		scoreString = GetComponent<Text> ();
		scoreShown = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.G)) {
			if (scoreShown) {
				scoreShown = false;
				scoreString.text = "Press G to see score";
			} else {
				scoreShown = true;
				scoreString.text = "Score: " + score;
			}
		}
	}
}
