﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyPoints : MonoBehaviour {
	public static TextMeshPro text;
	public static int points = 0;
	// Use this for initialization
	void Start () {
		 text = GetComponent<TextMeshPro>();
		text.text = "Your friend hit: " + points;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public static void addOnePoint(){
		points += 1;
		text.text = "Your friend hit: " + points;

	
	}
}
