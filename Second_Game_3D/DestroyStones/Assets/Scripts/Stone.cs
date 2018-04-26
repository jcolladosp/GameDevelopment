using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

	private const float yDie = -30.0f;
	public GameObject explosion;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < yDie) {
			Destroy (gameObject);
		}
	}

	void OnMouseDown(){
		Instantiate (explosion, transform.position, Quaternion.identity);
		Destroy (gameObject);
		GameManager.currentNumberStonesDestroyed++;

	}
}
