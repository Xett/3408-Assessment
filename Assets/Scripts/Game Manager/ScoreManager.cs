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
		scoreString.text = "Score: " + score;
	}
}
