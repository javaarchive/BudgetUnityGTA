using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject car;
    public float lastCameraToggle = 0f;

    public Vector3 camOffset = new Vector3(0, 3, -8);
    public Vector3 camOffsetFirstPerson = new Vector3(0, -2, 5);
    public bool isFirstPerson = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("shift") && (Time.deltaTime - lastCameraToggle) > 1){
            lastCameraToggle = Time.deltaTime;
            isFirstPerson = !isFirstPerson;
        }
        if(isFirstPerson){
            transform.position = car.transform.position + car.transform.rotation * camOffset;
        }else{
            transform.position = car.transform.position + car.transform.rotation * camOffsetFirstPerson;
        }
        transform.rotation = car.transform.rotation;
    }
}
