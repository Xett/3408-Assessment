using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimer : MonoBehaviour
{
    public float maxGameTime;
    public float gameTime;
    public float percentageDayComplete;

    // Use this for initialization
    void Start ()
    {
        gameTime = maxGameTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameTime -= Time.deltaTime;
        percentageDayComplete = gameTime / maxGameTime;
    }
}
