using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Configuration;
using UnityEngine;
using Random = UnityEngine.Random;

public class Chunk {
    public const int CUBE_COUNT = 16;
    public const int VERTEX_COUNT = CUBE_COUNT + 1;

    private Vertex[,,] vertices = new Vertex[VERTEX_COUNT, VERTEX_COUNT, VERTEX_COUNT];
    private Cube[,,] cubes = new Cube[CUBE_COUNT, CUBE_COUNT, CUBE_COUNT];

    private float isolevel = 0.5f;
    
    public Chunk() {
        for (int x = 0; x < VERTEX_COUNT; x++) {
            for (int y = 0; y < VERTEX_COUNT; y++) {
                for (int z = 0; z < VERTEX_COUNT; z++) {
                    vertices[x, y, z] = new Vertex(new Vector3(x, y, z), Random.Range(0f, 1f));
                    if (x >= 1 && y >= 1 && z >= 1) {
                        cubes[x-1, y-1, z-1] = new Cube(isolevel,
                                                        vertices[x, y-1, z-1],
                                                        vertices[x, y-1, z],
                                                        vertices[x-1, y-1, z],
                                                        vertices[x-1, y-1, z-1],
                                                        vertices[x, y, z-1],
                                                        vertices[x, y, z],
                                                        vertices[x-1, y, z],
                                                        vertices[x-1, y, z-1]);
                    }
                }
            }
        }
    }

    private int getVertexIndex(int x, int y, int z) {
        return x + (y * VERTEX_COUNT) + (z * VERTEX_COUNT * VERTEX_COUNT);
    }

    public void setVertex(float value, int x, int y, int z) {
        if (x < VERTEX_COUNT && y < VERTEX_COUNT && z < VERTEX_COUNT) {
            Vertex v = Vertices[x, y, z];
            v.Level = value;
            v.update();
        }
    }

    public void update() {
        foreach (var cube in Cubes) {
            cube.updateMesh(isolevel);
        }
    }

    public Vertex[,,] Vertices => vertices;

    public Cube[,,] Cubes => cubes;

    public float Isolevel {
        get => isolevel;
        set {
            isolevel = value;
            update();
        }
    }
}
