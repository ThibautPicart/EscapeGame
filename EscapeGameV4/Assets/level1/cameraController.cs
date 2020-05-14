using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public float speedH = 2.0f;
    public float speedV = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, GetComponent<Camera>().transform.eulerAngles.y, GetComponent<Camera>().transform.eulerAngles.z);
        //transform.eulerAngles.Set(pitch, camera.transform.eulerAngles.y, camera.transform.eulerAngles.z);
    }
}
