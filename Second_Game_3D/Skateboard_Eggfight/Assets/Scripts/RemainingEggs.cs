using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RemainingEggs : MonoBehaviour {
	public static TextMeshPro text;
	public static int eggs = 9;
	// Use this for initialization
	void Start () {
		 text = GetComponent<TextMeshPro>();
		text.text = "Remaining eggs: " + eggs;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void removeEgg(){
		eggs -= 1;
		text.text = "Remaining eggs: " + eggs;

	
	}
}
