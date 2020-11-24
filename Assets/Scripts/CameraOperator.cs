using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOperator : MonoBehaviour
{
    public GameObject player;
    public GameObject rotator;
    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Camera>().enabled = true;
        rotator.GetComponent<Camera>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            player.GetComponent<Camera>().enabled = !player.GetComponent<Camera>().enabled;
            rotator.GetComponent<Camera>().enabled = !rotator.GetComponent<Camera>().enabled;
        }
    }
}
