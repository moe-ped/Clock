﻿using UnityEngine;
using System.Collections;

public class TheFinalCountdown : MonoBehaviour {

	public float Timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Timer = Timer - Time.deltaTime;
			Debug.Log (Timer + " s "); 
	
	}
	private void LogTime (float seconds);
	LogTime () 
}
