using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetArray : MonoBehaviour {
	public string[] Pets;

	// Use this for initialization
	void Start () {
		Pets = new string[6];

		Pets[0] = "Dog";
		Pets[1] = "Cat";
		Pets[2] = "Bear";
		Pets[3] = "Fox";
		Pets[4] = "Lion";
		Pets[5] = "Mouse";

		foreach(string Animal in Pets){
			print("I have a pet " + Animal);
		}
	

	}
}