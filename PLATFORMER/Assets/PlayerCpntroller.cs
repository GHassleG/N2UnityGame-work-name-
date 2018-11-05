using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCpntroller : MonoBehaviour {

	public float speed = 20f;
	private Rigidbody2D rb;
	public Animator anim;

	void Start () {
		rb = GetComponent <Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void FixedUpdate () {
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.D)) {
			float moveX = Input.GetAxis ("Horizontal");
			rb.MovePosition (rb.position + Vector2.right * moveX * speed * Time.deltaTime);
			gameObject.GetComponent<Animator> ().SetTrigger ("run");
		} else {
			Idle ();
		}
	}

	void Idle (){
		gameObject.GetComponent<Animator> ().SetTrigger ("Idle");
	}
}
