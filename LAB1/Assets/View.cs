using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class View: MonoBehaviour {
	private Vector3 cameraPos;
	public Transform PlayerPos;

	[Range(0.01f, 1.0f)]
	public float SmoothFactor = 0.5f;
	void Start() {
		cameraPos = transform.position - PlayerPos.position;
	}
	void Update() {
        Vector3 updatedPosition = PlayerPos.position + cameraPos;
		transform.position = Vector3.Slerp(transform.position, updatedPosition, SmoothFactor);
		transform.LookAt(PlayerPos.transform);
	}
}