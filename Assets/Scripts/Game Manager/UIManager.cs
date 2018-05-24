using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public GameObject GameManager;
    GameTimer timer;

	Animator anim;

	// Use this for initialization
	void Start ()
    {
		anim = GetComponent<Animator> ();
        timer = GameManager.GetComponent<GameTimer>();
    }
	
	// Update is called once per frame
	void Update () {
		if (timer.gameTime <= 0)
        {
			anim.SetTrigger ("GameOver");
		}
	}
}
