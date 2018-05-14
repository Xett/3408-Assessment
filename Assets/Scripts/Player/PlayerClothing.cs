using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClothing : MonoBehaviour
{
    public GameObject hair;
    public GameObject leftEye;
    public GameObject rightEye;
    public GameObject singlet;
    public GameObject pants;
    public GameObject leftThong;
    public GameObject rightThong;

    public GameObject HeadTop_End;
    public GameObject LeftEye;
    public GameObject RightEye;
    public GameObject Spine2;
    public GameObject Hips;
    public GameObject LeftToe_End;
    public GameObject RightToe_End;
	// Use this for initialization
	void Start ()
    {
        hair.transform.SetParent(HeadTop_End.transform);
        leftEye.transform.SetParent(LeftEye.transform);
        rightEye.transform.SetParent(RightEye.transform);
        singlet.transform.SetParent(Spine2.transform);
        pants.transform.SetParent(Hips.transform);
        leftThong.transform.SetParent(LeftToe_End.transform);
        rightThong.transform.SetParent(RightToe_End.transform);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
