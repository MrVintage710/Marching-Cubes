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


    void OnMouseDown()
    {
        if(this.GetComponent<Renderer>().material.color == Color.white)
        {
            this.GetComponent<Renderer>().material.color = Color.grey;
            // add to the mesh
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.white;
            //remove from mesh
        }
        
    }
}

