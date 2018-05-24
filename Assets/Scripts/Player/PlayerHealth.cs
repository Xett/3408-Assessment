using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	Text healthString;
	public int currentHealth;

	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
		healthString = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		healthString.text = "Health: " + currentHealth;
	}

	public void TakeDamage(int amount) {
		currentHealth -= amount;
		//play hurt audio
	}
}
