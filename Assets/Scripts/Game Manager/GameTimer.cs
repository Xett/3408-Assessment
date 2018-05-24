using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float maxGameTime;
    public float gameTime;
	public float timeElasped;
    public float percentageDayComplete;

    // Use this for initialization
    void Start ()
    {
        gameTime = maxGameTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (gameTime > 0)
        {
			gameTime -= Time.deltaTime;
			percentageDayComplete = 1 - (gameTime / maxGameTime);
		}
    }
}
