using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject car;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = car.transform.position + car.transform.rotation * (new Vector3(0, 3, -8));
        transform.rotation = car.transform.rotation;
    }
}
