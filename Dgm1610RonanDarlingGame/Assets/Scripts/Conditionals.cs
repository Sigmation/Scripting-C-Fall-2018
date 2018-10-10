using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class Conditionals : MonoBehaviour {

	public string Weather;



	// Use this for initialization
	void Start () {
		if(Weather == "Raining")
			print("Weather is" + Weather);
		else if(Weather == "Snowing")
			print("Weather is" + Weather);
		else if(Weather == "Sunny")
			print("Weather is" + Weather);	
		else if(Weather == "Cloudy")
			print("Weather is" + Weather);
		else
			print("I dont know" + Weather);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
