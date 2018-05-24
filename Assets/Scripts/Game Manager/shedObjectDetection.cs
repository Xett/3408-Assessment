using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shedObjectDetection : MonoBehaviour {

	public int scoreValue = 10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// whenever pickup item enters shed, score increases
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "pickupItem") {
			ScoreManager.score += scoreValue;
		}
	}

	// whenever pickup item leaves shed, score decreases
	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "pickupItem") {
			ScoreManager.score -= scoreValue;
		}
	}
}
