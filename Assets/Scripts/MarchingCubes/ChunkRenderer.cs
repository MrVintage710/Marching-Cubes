using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GD.MinMaxSlider;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class ChunkRenderer : MonoBehaviour {
    private Chunk chunk;
    private MeshFilter meshFilter;

    public GameObject cubeObject;
    
    [Range(0, 1)]
    public float isolevel = 0.5f;

//    [MinMaxSlider(0, Chunk.CUBE_COUNT * Chunk.CUBE_COUNT * Chunk.CUBE_COUNT)]
//    public Vector2Int minMaxRender = new Vector2Int(0, Chunk.CUBE_COUNT * Chunk.CUBE_COUNT * Chunk.CUBE_COUNT);

    void Awake() {
        meshFilter = GetComponent<MeshFilter>();
        chunk = new Chunk();

        if (transform.childCount <= 0) {
            foreach (var cube in chunk.Cubes) {
                addCube(cube);
            }
        }
        
        updateMesh();
    }

    private void addCube(Cube cube) {
        GameObject go = Instantiate(cubeObject, new Vector3(), Quaternion.identity);
        go.transform.parent = gameObject.transform;
        go.GetComponent<CubeRenderer>().Cube = cube;
        go.SetActive(false);
    }
    
    private void OnValidate() {
        updateMesh();
    }

    private void updateMesh() {
        if (chunk != null) {
            chunk.Isolevel = isolevel;
            
            List<CombineInstance> instances = new List<CombineInstance>();
            for (int i = 0; i < transform.childCount; i++) {
                GameObject go = transform.GetChild(i).gameObject;
                MeshFilter mf = go.GetComponent<MeshFilter>();
                
                CombineInstance ci = new CombineInstance();
                ci.mesh = mf.sharedMesh;
                ci.transform = go.transform.localToWorldMatrix;
                instances.Add(ci);
            }
            GetComponent<MeshFilter>().mesh.Clear();
            GetComponent<MeshFilter>().mesh.CombineMeshes(instances.ToArray());
        }
    }

    private void OnDrawGizmos() {
        if (chunk != null) {
            Gizmos.color = Color.blue;
            Gizmos.DrawWireCube(transform.position + new Vector3(Chunk.CUBE_COUNT/2f,Chunk.CUBE_COUNT/2f,Chunk.CUBE_COUNT/2f), 
                                new Vector3(1, 1, 1) * (Chunk.CUBE_COUNT));
        }
    }
}
