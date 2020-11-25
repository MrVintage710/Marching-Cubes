using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class nodeScript : MonoBehaviour {
    private World world;
    
    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Renderer>().material.color = Color.white;
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
    }

    void OnMouseDown()
    {
        if(this.GetComponent<Renderer>().material.color == Color.white)
        {
            this.GetComponent<Renderer>().material.color = Color.grey;
            // add to the mesh
            Debug.Log("Click");
        }
        
        else
        {
            this.GetComponent<Renderer>().material.color = Color.white;
            //remove from mesh
        }
    }

    void OnMouseOver()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 1.0f);
    }
    void OnMouseExit()
    {
        this.GetComponent<MeshRenderer>().material.color = new Color(1.0f, 1.0f, 1.0f, 0.05f);
    }
}

