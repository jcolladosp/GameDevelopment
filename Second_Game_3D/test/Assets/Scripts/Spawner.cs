using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
	public GameObject stone;
	public float fireRate = 0.5f;
	// Use this for initialization
	void Start ()
	{
		StartCoroutine (ThrowStone());
	}
	
	// Update is called once per frame
	void Update ()
	{

	
	}

	IEnumerator ThrowStone(){
		while (true) {
			Instantiate (stone, transform.position, Random.rotation);
			yield return new WaitForSeconds (fireRate);
		}
	}
}

