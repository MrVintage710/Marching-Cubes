
using System.Collections.Generic;
using UnityEngine;

public class Vertex {
	private Vector3 pos = new Vector3();
	private float level;
	
	private List<Cube> adjacentCubes = new List<Cube>();
	
	public Vector3 Pos => pos;

	public float Level {
		get => level;
		set => level = value;
	}

	public Vertex(Vector3 pos, float level) {
		this.pos = pos;
		this.level = level;
	}

	public Vertex(float x, float y, float z, float level) {
		pos = new Vector3(x ,y ,z);
		this.level = level;
	}

	public void update() {
		foreach (var cube in adjacentCubes) {
			cube.updateMesh(level);
		}
	}

	public void addAdjacentCube(Cube cube) {
		this.adjacentCubes.Add(cube);
	}
}