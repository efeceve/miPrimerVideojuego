using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public float jumpForce = 20.0f;
	public float runnigSpeed = 3.0f;
	private Rigidbody2D rigidBody;
	public LayerMask groundLayerMask;
	public Animator animator;

	void Awake(){
		rigidBody = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		animator.SetBool ("isAlive", true);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Jump ();
			//Debug.Log ("Se ha presionado el boton izquierdo del mouse");
		}
		animator.SetBool ("isGrounded", IsOnTheFloor ());
	}

	void FixedUpdate(){
		if (rigidBody.velocity.x < runnigSpeed) {
			rigidBody.velocity = new Vector2 (runnigSpeed, rigidBody.velocity.y);
		}
	}

	void Jump(){
		if (IsOnTheFloor ()) {
			rigidBody.AddForce (Vector2.up * jumpForce, ForceMode2D.Impulse);
		}
	}

	bool IsOnTheFloor(){
		if (Physics2D.Raycast (this.transform.position, Vector2.down, 1.3f, groundLayerMask.value)) {
			return true;
		} else {
			return false;
		}
	}
	
}
