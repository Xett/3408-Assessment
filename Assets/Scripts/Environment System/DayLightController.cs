using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayLightController : MonoBehaviour
{
    public GameObject directionalLight;
    public GameObject GameManager;

    // Use this for initialization
    void Start ()
    {
        if(directionalLight==null)
        {
            directionalLight = GameObject.FindWithTag("directionalLight");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {
        float percentageDayComplete = GameManager.GetComponent<GameTimer>().percentageDayComplete;
        // Light direction
        float xAngle = 180 * percentageDayComplete;
        Quaternion newRotation = Quaternion.Euler(xAngle, 0, 0);
        directionalLight.transform.rotation = newRotation;
	}
}
