using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    //Component that adds the opportunity to control Player's Position using Physics Engine
    private Rigidbody rb;
	public AudioClip impact;
	AudioSource audioSource;
	private Vector3 resetPlayer; // variable that resets player position
	/// </summary>
    public float speed;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();

		resetPlayer = transform.position; 
    }

	
	// Update is called once per frame
	void FixedUpdate ()
    {
        //allows Player Movement through the 2 different axises, Up & Down, Left & Right
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);

		if (Input.GetKeyDown (KeyCode.R)) {

			transform.position = resetPlayer; 

		}



	}
}
