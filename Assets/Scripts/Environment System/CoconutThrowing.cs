using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class CoconutThrowing : MonoBehaviour {

	public GameTimer timer;
	public Rigidbody coconut;
	public float speed;
	public PlayerHealth health;

	//Camera playerCam;
	Vector3 position;
	Vector3 playerPosition;
	Transform player;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("LaunchProjectile", 5f, 5f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = Quaternion.identity;
	}

	void LaunchProjectile () {
		if (timer.gameTime >= 0) {
			System.Random rand = new System.Random ();

			GameObject playerObject = GameObject.Find ("Player");
			playerPosition = playerObject.transform.position;
			player = playerObject.transform;
			int randNum = rand.Next (1, 2);

			position.x = playerPosition.x + (float)rand.Next (-10, 10);
			position.y = playerPosition.y + (float)rand.Next(1, 3);
			if (randNum == 1) {
				position.z = playerPosition.z + (float)rand.Next (60, 80);
			} else {
				position.z = playerPosition.z + (float)rand.Next (-60, -80);
			}

			Rigidbody instance = Instantiate (coconut, position, Quaternion.Euler(0, 0, 0));
			instance.AddForce ((transform.forward * -1) * speed);
		}
	}

	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "projectile") {
			health.TakeDamage(50);
			col.attachedRigidbody.useGravity = true;
		}
	}
}
