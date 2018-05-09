﻿using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {

	public float wanderRadius;
	public float wanderTimer;

	private Transform target;
	private UnityEngine.AI.NavMeshAgent agent;
	private float timer;
	public GameObject egg;
	public GameObject avatar;

	// Use this for initialization
	void OnEnable () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		timer = wanderTimer;

	}
	void Start () {
		InvokeRepeating("ThrowEggs", 0, 2.0f);
		avatar = GameObject.Find("avatar");

	}


	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;

		if (timer >= wanderTimer) {
			Vector3 newPos = RandomNavSphere(transform.position, wanderRadius, -1);
			agent.SetDestination(newPos);
			timer = 0;
		}
	}

	public static Vector3 RandomNavSphere(Vector3 origin, float dist, int layermask) {
		Vector3 randDirection = Random.insideUnitSphere * dist;

		randDirection += origin;

		UnityEngine.AI.NavMeshHit navHit;

		UnityEngine.AI.NavMesh.SamplePosition (randDirection, out navHit, dist, layermask);

		return navHit.position;
	}

	private void ThrowEggs()
	{
		// Initial delay
		Instantiate (egg, avatar.transform.position + new Vector3(0,3,0), Quaternion.identity);


	}


}