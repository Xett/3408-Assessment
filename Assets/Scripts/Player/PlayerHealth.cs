using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {

	public int startingHealth = 100;
	Text healthString;
	public int currentHealth;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		currentHealth = startingHealth;
		audio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void TakeDamage(int amount) {
		currentHealth -= amount;
		//play hurt audio
		audio.Play();
	}
}
