using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
	Rigidbody rigidBody;

	void Start(){
		rigidBody = GetComponent<Rigidbody>();
		rigidBody.centerOfMass = new Vector3(0,-1,0);
	}

	void Update(){
		float forwardForce = Input.GetAxis ("Vertical") * Time.deltaTime * 1000;
		//  transform.forward
		rigidBody.AddForce((forwardForce * transform.forward), ForceMode.Acceleration);
		// transform.Translate(Input.GetAxis ("Vertical") * transform.forward * Time.deltaTime * 15, Space.World);	
		transform.Rotate(0,Input.GetAxis("Horizontal"),0);
	}
}