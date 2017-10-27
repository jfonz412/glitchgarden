﻿using UnityEngine;
using System.Collections;

public class Defender : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(gameObject.tag == "Projectile"){
			Rigidbody2D myRigidBody = gameObject.AddComponent<Rigidbody2D>();
			myRigidBody.isKinematic = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.gameObject.tag);
		if(other.gameObject.tag == "Attacker"){
			Debug.Log ("Defender under attack!");
		}
	}
}
