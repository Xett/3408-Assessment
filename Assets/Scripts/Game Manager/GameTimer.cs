using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    public float maxGameTime;
	Text timerString;
    public float gameTime;
	public float timeElasped;
    public float percentageDayComplete;

    // Use this for initialization
    void Start ()
    {
		timerString = GetComponent<Text> ();
        gameTime = maxGameTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (gameTime > 0) {
			gameTime -= Time.deltaTime;
			timeElasped += Time.deltaTime;
			int mins = Mathf.FloorToInt (gameTime / 60F);
			int secs = Mathf.FloorToInt (gameTime - mins * 60);
			string formattedTime = string.Format ("{0:0}:{1:00}", mins, secs);
			timerString.text = formattedTime;
			percentageDayComplete = gameTime / maxGameTime;
		}
    }
}
