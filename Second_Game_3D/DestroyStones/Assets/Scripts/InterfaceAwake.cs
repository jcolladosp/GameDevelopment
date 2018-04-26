﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceAwake : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameManager.currentNumberStonesDestroyed = 0;
		GameManager.currentNumberStonesThrown = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void onClick(){
		SceneManager.LoadScene("StoneGame")	;
	}
}
