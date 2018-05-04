using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightTimer : MonoBehaviour
{
    public GameObject directionalLight;
    public float maxGameTime;
    private static float gameTime;
    public Text timerText;

    // Use this for initialization
    void Start ()
    {
        if(directionalLight==null)
        {
            directionalLight = GameObject.FindWithTag("directionalLight");
        }
        gameTime = maxGameTime;
	}
	
	// Update is called once per frame
	void Update ()
    {
        gameTime -= Time.deltaTime;

        // Light direction
        float percentageDayComplete = gameTime / maxGameTime;
        float xAngle = 180 * percentageDayComplete;
        Quaternion newRotation = Quaternion.Euler(xAngle, 0, 0);
        directionalLight.transform.rotation = newRotation;

        timerText.text = "Timer: " + gameTime;
	}
}
