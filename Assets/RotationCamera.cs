using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCamera : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.Rotate(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.Rotate(0, -speed * Time.deltaTime, 0);
        }


    }
}
