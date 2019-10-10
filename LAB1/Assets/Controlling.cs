using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controlling: MonoBehaviour {
	public CharacterController controller;
    public float jump;
    public float jumpSpeed;
    public float gravity;
    public Vector3 Vector;
	public float jumpBoost;
	public float speed;
	
    
	void Start() {
		speed = 5f;
		jump = 1f;
        gravity = 1f;
        controller = this.GetComponent<CharacterController>();

    }

    void Update() {
        jumpBoost -= gravity * Time.deltaTime;
			    if (Input.GetKeyDown(KeyCode.Space)) {
                jumpBoost = jump;
			}

		Vector = new Vector3(Input.GetAxis("Horizontal"), jumpBoost, Input.GetAxis("Vertical"));
		Vector *= speed;
		transform.LookAt(transform.position + new Vector3(Vector.x, 0, Vector.z));
		controller.Move(Vector * Time.deltaTime);
	}
}