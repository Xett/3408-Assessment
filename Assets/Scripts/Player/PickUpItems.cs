using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class PickUpItems : MonoBehaviour {
	
	public bool holdingItem = false;
	public GameObject pickupItem;
	public Transform guide;
	public Camera cam;
	public float closestDistance = -0f;
	public List<Collider> TriggerList = new List<Collider>();
    public Animator anim;

	void Start() {
		anim = GetComponent<Animator>();
	}
		
	void Update() {
		//checks for an input press on every frame
		if (Input.GetKeyDown("return")) {
			if (holdingItem)
            {
                placeDown();
			}
			else
            {
                anim.SetTrigger("Pickup");
                pickUp();
            }
		}

		//if one or more objects are within a collider, distance between player and object is calculated
		if (!holdingItem && TriggerList.Any()) {
			foreach (Collider singlecol in TriggerList) {
				float distance = Vector3.Distance(cam.transform.position, singlecol.transform.position);

				if (closestDistance == -0f) {
					closestDistance = distance;
					pickupItem = singlecol.gameObject;
				}
				else {
					if (distance < closestDistance) {
						closestDistance = distance;
						pickupItem = singlecol.gameObject;
					} 
				}

				closestDistance = -0f;
			}

		}

		//
		if (holdingItem && pickupItem) {
			pickupItem.transform.position = guide.position;
		}
	}

	//when player comes into contact area with object
	void OnTriggerEnter(Collider col) {
		if (holdingItem) {
			return;
		}

		if (col.gameObject.tag == "pickupItem") {
			if (!TriggerList.Contains (col)) {
				TriggerList.Add (col);
			}
		}
	}

	//when player comes out of contact area with object
	void OnTriggerExit(Collider col) {
		if (holdingItem) {
			return;
		}

		if (col.gameObject.tag == "pickupItem") {
			if (TriggerList.Contains(col)) {
				TriggerList.Remove(col);
			}

			if (col.gameObject == pickupItem) {
				pickupItem = null;
			}
		}
	}
		
	private void pickUp() {
		if (!pickupItem) {
			return;
		}

		//Set object parent to our guide empty object.
		pickupItem.transform.SetParent(guide);

		//when carrying object, it does not effect any objects
		pickupItem.GetComponent<Rigidbody> ().isKinematic = true;

		//we apply the same rotation our main object (Camera) has.
		pickupItem.transform.localRotation = transform.rotation;

		//Reposition transform based on guide
		pickupItem.transform.position = guide.position;

		//clear closest distance
		closestDistance = -0f;

		holdingItem = true;
	}

	private void placeDown() {
		if (!pickupItem) {
			return;
		}

		//regular physics
		pickupItem.GetComponent<Rigidbody> ().isKinematic = false;

		//Unparent our ball
		guide.GetChild(0).parent = null;

		holdingItem = false;
    }
}
