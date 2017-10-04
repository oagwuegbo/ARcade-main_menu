using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class ShipController : MonoBehaviour {

	private Rigidbody rb;
	public Transform[] point;
	public Rigidbody laser;


	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update ()
	{
		float x = CrossPlatformInputManager.GetAxis ("Horizontal");
		float y = CrossPlatformInputManager.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (x, 0.0f, y);

		rb.velocity = movement * 1f;

		if (x != 0 && y != 0)
		{
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, Mathf.Atan2 (x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
		}

		if(CrossPlatformInputManager.GetButtonDown("Jump"))
		{
			Rigidbody laserInstance	= Instantiate(laser, point[0].position, point[0].rotation) as Rigidbody;
			Rigidbody laserInstance2 = Instantiate(laser, point[1].position, point[1].rotation) as Rigidbody;

			laserInstance.velocity = point [0].up * -8.0f;
			laserInstance2.velocity =point [1].up * -8.0f;
		}
	}	
}