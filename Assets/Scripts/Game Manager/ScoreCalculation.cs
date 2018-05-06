using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCalculation : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// whenever pickup item enters shed, score increases
	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "pickupItem") {
				score += 10;
		}
	}

	// whenever pickup item leaves shed, score decreases
	void OnTriggerExit(Collider col) {
		if (col.gameObject.tag == "pickupItem") {
			score -= 10;
		}
	}
}
