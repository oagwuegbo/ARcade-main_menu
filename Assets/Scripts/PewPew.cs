using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewPew : MonoBehaviour {
	
	private Rigidbody rb;
	public Transform Ship;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
	}

	
	// Update is called once per frame
	void Update ()
	{
		Vector3 movement = new Vector3 ();

		//enter trumps speed here!!!
		rb.velocity = movement * 1f;
		
	}
}
