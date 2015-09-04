using UnityEngine;
using System.Collections;

public class TheFinalCountdown : MonoBehaviour {

	public float Timer = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Timer = Timer - Time.deltaTime;
			
		LogTime (Timer);
	}
	private void LogTime (float seconds){
	
		float Minutes = seconds / 60;
		Minutes = Mathf.Floor (Minutes);
		seconds = seconds - Minutes * 60;
		seconds = Mathf.Floor (seconds);
		float Hours = Minutes / 60;
		Hours = Mathf.Floor (Hours);
	
		Debug.Log (Hours + "h" + Minutes + "m" + seconds + "s");

	}
}
