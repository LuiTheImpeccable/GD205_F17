using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrust : MonoBehaviour {

	Rigidbody  rb; //Creating Rigidbody component variable
	public float ThrustAmount;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>(); //rb variable is connected with the Rigidbody component in the Sphere inspector
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)) { //If player presses W key
			rb.AddForce (Vector3.forward * ThrustAmount); //rb variable is going to add force for the GameObject(Sphere) to move in that certain direction,
		}
			if (Input.GetKey(KeyCode.S)) { //If player presses S key
				rb.AddForce (Vector3.back * ThrustAmount); // rb variable is going to add force for the GameObject(Sphere) to move in that certain direction.
				}
	}
}