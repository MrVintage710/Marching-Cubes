using System;
using UnityEngine;

public class World : MonoBehaviour {
	
	public GameObject chunk;
	private void Start() {
		createChunk(0, 0, 0);	
	}

	private void createChunk(int x, int y, int z) {
		GameObject chunk =
			Instantiate(this.chunk, new Vector3(x * Chunk.CUBE_COUNT, x * Chunk.CUBE_COUNT, x * Chunk.CUBE_COUNT),
			            Quaternion.identity);
		chunk.transform.parent = transform;
	}
}