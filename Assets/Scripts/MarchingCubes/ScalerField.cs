using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalerField
{
    // a data structure where we are going to store chunks
    private bool[ , , ] nodes;
    // Here is where we initialize our field
    public ScalerField(int x, int y, int z)
    {
        if(x == 0 || y == 0 || z == 0)
        {
            nodes = new bool[50, 50, 50];
        }
        else
        {
            nodes = new bool[x, y, z];
        }
    }
    
    // Here is where we change the value of a particular node.
    public void flipNode(int x, int y, int z)
    {
        nodes[x, y, z] = !nodes[x, y, z];
    }
    // Here is where we get the particular value of a node
    public bool getNode(int x, int y, int z)
    {
        return nodes[x, y, z];
    }


    public void setNode(int x, int y, int z, bool value)
    {
        nodes[x, y, z] = value;
    }
}
