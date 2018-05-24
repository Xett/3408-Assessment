using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerTextUpdate : MonoBehaviour {

    public GameObject GameManager;
    Text timerString;

    void Start ()
    {
        timerString = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        int mins = Mathf.FloorToInt(GameManager.GetComponent<GameTimer>().gameTime / 60F);
        int secs = Mathf.FloorToInt(GameManager.GetComponent<GameTimer>().gameTime - mins * 60);
        string formattedTime = string.Format("{0:0}:{1:00}", mins, secs);
        timerString.text = formattedTime;
    }
}
