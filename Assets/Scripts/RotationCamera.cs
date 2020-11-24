using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCamera : MonoBehaviour
{
    public float speed;
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    public float speedH = 4.0f;
    public float speedV = 4.0f;
    public GameObject rotatingcamera;


    // Update is called once per frame
    void Update()
    {
        Vector3 pos = this.transform.position;
        var d = Input.GetAxis("Mouse ScrollWheel");

        if (d > 0f)
        {
            //pos.z += 1;
        }
        else if (d < 0f)
        {
            //pos.z -= 1;
        }
        transform.position = pos;


        if (Input.GetKey("right"))
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))
        { 
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        }

        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        if (Input.GetKey(KeyCode.Mouse1))
        {
            rotatingcamera.transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        }

        
    }
}
