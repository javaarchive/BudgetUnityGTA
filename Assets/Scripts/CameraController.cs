using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject car;
    public float lastCameraToggle = 0f;

    public Vector3 camOffset = new Vector3(0, 3, -8);
    public Vector3 camOffsetFirstPerson = new Vector3(0,1,2);
    public bool isFirstPerson = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // prevent key from triggering every frame
        if(Input.GetKey(KeyCode.Space) && (Time.realtimeSinceStartup - lastCameraToggle) > 1f){
            lastCameraToggle = Time.realtimeSinceStartup;
            isFirstPerson = !isFirstPerson;
        }
        if(isFirstPerson){
            transform.position = car.transform.position + car.transform.rotation * camOffsetFirstPerson;
            transform.rotation = car.transform.rotation;
        }else{
            transform.position = car.transform.position + car.transform.rotation * camOffset;
            transform.rotation = car.transform.rotation;
        }
       
    }
}
