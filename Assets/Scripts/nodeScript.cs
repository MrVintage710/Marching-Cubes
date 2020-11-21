using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nodeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray,out hit, 100.0f))
            {
                if(hit.transform != null)
                {
                    if(this.GetComponent<Renderer>().material.color == Color.white)
                    {
                        this.GetComponent<Renderer>().material.color = Color.gray;
                        // send the node info as active
                    }
                    else
                    {
                        this.GetComponent<Renderer>().material.color = Color.white;
                        // send the node info as deactive
                    }
                    Destroy(this.gameObject);

                }
            }
        }
    }
}
