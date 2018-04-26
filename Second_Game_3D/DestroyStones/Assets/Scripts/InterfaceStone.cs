using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceStone : MonoBehaviour {
	public Text textThrown;
	public Text textDestroyed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		textThrown.text = "Number of stones: " + GameManager.currentNumberStonesThrown;
		textDestroyed.text = " Destroyed: " + GameManager.currentNumberStonesDestroyed;
		
	}
}
