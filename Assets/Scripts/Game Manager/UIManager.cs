using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public GameObject GameManager;

    GameTimer timer;
	Animator anim;
	PlayerHealth health;

	// Use this for initialization
	void Start ()
    {
		anim = GetComponent<Animator> ();
        timer = GameManager.GetComponent<GameTimer>();
		health = GameManager.GetComponent<PlayerHealth> ();
    }
	
	// Update is called once per frame
	void Update () {
		if (timer.gameTime <= 0)
        {
			anim.SetTrigger ("GameOver");
		}

		if (health.currentHealth <= 0) {
			anim.SetTrigger ("GameOver");
		}
	}
}
