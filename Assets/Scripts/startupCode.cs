using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startupCode : MonoBehaviour
{
    int chunkNumber = 1;
    public GameObject Node;
    // Start is called before the first frame update
    void Start()
    {
        int nodeScript = chunkNumber * 25;

        for(int i = 0; i<= nodeScript; i++)
        {
            for(int r = 0; r <= nodeScript; r++)
            {
                for(int t = 0; t<= nodeScript; t++)
                {
                    //Instantiate(Node, new Vector3(i, r, t), Quaternion.identity);
                }
            }
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
