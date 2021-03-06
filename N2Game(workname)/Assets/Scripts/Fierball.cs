﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fierball : MonoBehaviour {
	public float speed = 10.0f;
	public float damage = 0.1f;

	void Start () {
		
	}

	void Update () {
		transform.Translate (0, 0, speed * Time.deltaTime);
		Invoke("NotDestroyed",2);
	}

	void OnTriggerEnter(Collider other){
		ReactiveTarget target = other.GetComponent<ReactiveTarget> ();
			if(target != null){
			target.ReactToHit();
		}
			
		if (other.tag != "N2wall") {
			Destroy (this.gameObject);
		}

	}

	void NotDestroyed (){
		Destroy (this.gameObject, 2);
	}
}