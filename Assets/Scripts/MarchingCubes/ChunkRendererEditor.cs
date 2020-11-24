using System;
using UnityEditor;

[CanEditMultipleObjects]
[CustomEditor(typeof(ChunkRenderer))]
public class ChunkRendererEditor : Editor {
	
	private ChunkRenderer renderer;

	private void OnEnable() {
		renderer = (ChunkRenderer) target;
	}
}