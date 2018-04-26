using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
	public float forceValue;
	public float jumpValue;
	private AudioSource audio;
	private Rigidbody rigidbody;
	private int life = 100;
	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
		audio = GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump") && Mathf.Abs (rigidbody.velocity.y) < 0.01f) {
			rigidbody.AddForce (Vector3.up * jumpValue, ForceMode.Impulse);
			//audio.Play ();
		}
	}

	void FixedUpdate(){
		rigidbody.AddForce(new Vector3(Input.GetAxis("Horizontal"),
										0,
									Input.GetAxis("Vertical"))*forceValue);

	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Enemigo") {
			print ("colision");
			life -= 10;
			if (life == 0) {
				//Destroy (gameObject);
			}
			//Destroy (collision.gameObject);
		}
	}

	void OnTriggerEnter(Collider other){
		print ("triggered");
	}
}
