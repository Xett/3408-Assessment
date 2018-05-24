using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float sensitivityX;
    public float sensitivityY;
    public float minimumX = -60f;
    public float maximumX = 60f;
    public float minimumY = 360f;
    public float maximumY = 360f;

    public Camera playerCamera;

    Vector3 movement;
    Rigidbody playerRigidbody;
    Animator anim;

    float rotationX = 0f;
    float rotationY = 0f;

	// Use this for initialization
	void Awake ()
    {
        Cursor.lockState = CursorLockMode.Locked;
        playerRigidbody = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        rotationX += Input.GetAxis("Mouse Y")*sensitivityX;
        rotationY += Input.GetAxis("Mouse X")*sensitivityY;

        rotationX = Mathf.Clamp(rotationX, minimumX, maximumX);

        Movement(h, v);
        Turning();
        Animating(h, v);
	}

    void Movement(float h, float v)
    {
        movement = (transform.forward*v) + (transform.right*h);
        movement = movement.normalized * speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }

    void Turning()
    {
        playerRigidbody.MoveRotation(Quaternion.Euler(0, rotationY, 0));
        playerCamera.transform.rotation = Quaternion.Euler(-rotationX, rotationY, 0);
    }

    void Animating(float h, float v)
    {
		bool walking = h != 0f || v != 0f;
		anim.SetBool("isWalking", walking);
    }
}
