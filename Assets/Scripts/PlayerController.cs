using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
	Rigidbody rigidBody;

	void Start(){
		rigidBody = GetComponent<Rigidbody>();
		// makes thing not flip over
		// thanks landon for physics explaination
		rigidBody.centerOfMass = new Vector3(0,-1,0);
	}

	void Update(){
		float forwardForce = Input.GetAxis ("Vertical") * Time.deltaTime * 1000;
		//  transform.forward
		rigidBody.AddForce((forwardForce * transform.forward), ForceMode.Acceleration);
		// transform.Translate(Input.GetAxis ("Vertical") * transform.forward * Time.deltaTime * 15, Space.World);	
		transform.Rotate(0,Input.GetAxis("Horizontal"),0);
		if(Input.GetKey(KeyCode.Space)){
			// lmao fly
			rigidBody.AddForce((Vector3.up * 5), ForceMode.Acceleration);
		}
	}
}