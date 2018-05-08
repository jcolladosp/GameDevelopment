using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggImpulse : MonoBehaviour {
	public float impulseForce = 15.0f;
	public float impulseForceUp = 3.0f;


	private GameObject eggHand;

	// Use this for initialization
	void Start () {
		eggHand = GameObject.Find("eggHand");
		GetComponent<Rigidbody> ().AddRelativeForce ((-eggHand.transform.forward) * impulseForce, ForceMode.Impulse);
		GetComponent<Rigidbody> ().AddRelativeForce ((eggHand.transform.up) * impulseForceUp, ForceMode.Impulse);

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0.0f) {
			Destroy (gameObject);
		}
	}
}
