using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerController : MonoBehaviour {
	void Start(){

	}

	void Update(){
		transform.Translate(Input.GetAxis ("Vertical") * transform.forward * Time.deltaTime * 15, Space.World);	
		transform.Rotate(0,Input.GetAxis("Horizontal"),0);
	}
}