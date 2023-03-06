using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovementProvider : MonoBehaviour
{
    Rigidbody rigidBody;

	void Start(){
		rigidBody = GetComponent<Rigidbody>();
		// makes thing not flip over
		// thanks landon for physics explaination
		// rigidBody.centerOfMass = new Vector3(0,-1,0);
	}

	void Update(){
		float forwardForce = Input.GetAxis ("Vertical") * Time.deltaTime * 120000;
		//  transform.forward
        // Debug.Log("Forward force " + forwardForce + " " + (forwardForce * transform.forward));
		// kinematic does not support forces
        // rigidBody.AddForce((forwardForce * transform.forward), ForceMode.Force);
		transform.Translate((Input.GetKey(KeyCode.Space) ? Time.deltaTime : 0) * transform.forward * Time.deltaTime * 15, Space.World);	
		transform.Rotate(Input.GetAxis ("Vertical"),Input.GetAxis("Horizontal"),0);
		if(Input.GetKey(KeyCode.Space)){
			// lmao fly
			// rigidBody.AddForce((Vector3.up * 15), ForceMode.Acceleration);
		}
	}
}
