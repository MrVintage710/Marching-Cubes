using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScalerField : MonoBehaviour
{
    // a data structure where we are going to store chunks
    bool[][][] nodes;
    // a function for flipping the boolean value of a node
    void setNode(bool node)
    {
        node = !node;
        onNodeChange();
    }
    bool getNode(int x, int y, int z)
    {
        return nodes[x][y][z];
    }
    public void onNodeChange()
    {
        //call reload(); check pdf in discord chat for more info.
        // is added onto a empty to be played when a node is changed
    }

}
