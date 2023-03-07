using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovementProvider : MonoBehaviour
{

	public GameObject propeller;

    Rigidbody rigidBody;

	bool shouldAnnoyPlayer = false;

	void Start(){
		rigidBody = GetComponent<Rigidbody>();
		// makes thing not flip over
		// thanks landon for physics explaination
		// rigidBody.centerOfMass = new Vector3(0,-1,0);
	}

	void OnCollisionEnter(Collision collision)
    {
        shouldAnnoyPlayer = true;
    }

	void Update(){
		float forwardForce = Input.GetAxis ("Vertical") * Time.deltaTime * 120000;
		//  transform.forward
        // Debug.Log("Forward force " + forwardForce + " " + (forwardForce * transform.forward));
		// kinematic does not support forces
        // rigidBody.AddForce((forwardForce * transform.forward), ForceMode.Force);
		transform.Translate((Input.GetKey(KeyCode.Space) ? 1f : 0.2f) * transform.forward * Time.deltaTime * 50, Space.World);	
		float roll = ((Input.GetKey(KeyCode.Z) ? Time.deltaTime : 0) + (Input.GetKey(KeyCode.C) ? -Time.deltaTime : 0)) * 30f;
		transform.Rotate(Input.GetAxis ("Vertical")*-1,Input.GetAxis("Horizontal"),roll);
		if(Input.GetKey(KeyCode.Space)){
			// legacy fly code
			// pls ignore
			// rigidBody.AddForce((Vector3.up * 15), ForceMode.Acceleration);
		}
		if(shouldAnnoyPlayer){
			transform.Rotate(Time.deltaTime * 360f,0f,0f);
		}
		if(Input.GetKey(KeyCode.RightShift)){
			// motion sickness cheat code
			shouldAnnoyPlayer = false;
		}

		propeller.transform.Rotate(0,0,Time.deltaTime * 720f);
	}
}
