using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Serialization;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class CubeRenderer : MonoBehaviour {
    
    private MeshFilter meshFilter;
    private Cube cube;
    private float isoLevel = 0.5f;


//    [Range(0.0f, 1.0f)]
//    public float v0 = 0.5f;
//    [Range(0.0f, 1.0f)]
//    public float v1 = 0.5f;
//    [Range(0.0f, 1.0f)]
//    public float v2 = 0.5f;
//    [Range(0.0f, 1.0f)]
//    public float v3 = 0.5f;
//    [Range(0.0f, 1.0f)]
//    public float v4 = 0.5f;
//    [Range(0.0f, 1.0f)]
//    public float v5 = 0.5f;
//    [Range(0.0f, 1.0f)]
//    public float v6 = 0.5f;
//    [Range(0.0f, 1.0f)]
//    public float v7 = 0.5f;
    
    
    void Awake() {
        meshFilter = GetComponent<MeshFilter>();
    }

    private void OnDrawGizmosSelected() {
        if (cube != null) {
            Gizmos.color = Color.white;
            Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 1));
            foreach (var vert in cube.Mesh.vertices) {
                Gizmos.color = Color.cyan;
                Gizmos.DrawWireSphere(transform.position + vert, 0.05f);
            }
        }
    }

    public Cube Cube {
        get => cube;
        set {
            cube = value;
            GetComponent<MeshFilter>().mesh = cube.Mesh;
            transform.position = cube.MiddlePoint;
        }
    }

    public float IsoLevel {
        get => isoLevel;
        set {
            isoLevel = value;
            cube.updateMesh(isoLevel);
        }
    }
}
