using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTextUpdate : MonoBehaviour {

	public GameObject GameManager;
	Text healthString;

	// Use this for initialization
	void Start () {
		healthString = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		int health = GameManager.GetComponent<PlayerHealth> ().currentHealth;
		healthString.text = "Health: " + health;
	}
}
