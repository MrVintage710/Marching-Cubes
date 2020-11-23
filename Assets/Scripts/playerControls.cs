using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    public float speed = 10.4f;

    public float speedH = 4.0f;
    public float speedV = 4.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
        // code for controlling key moving inputs
        Vector3 pos = this.transform.position;
        if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("q"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("e"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("space"))
        {

        }
        transform.position = pos;
    }
}
