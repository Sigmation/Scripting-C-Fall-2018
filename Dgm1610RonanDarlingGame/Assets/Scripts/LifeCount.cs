using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class LifeCount : MonoBehaviour {

public static int Lifes;

	Text LifesCount;

	// Use this for initialization
	void Start () {
		LifesCount = GetComponent<Text>();

		Lifes = 3; 
		}
	
	// Update is called once per frame
	void Update () {
		if (Lifes < 0)
		    Lifes = 0;
		LifesCount.text = " " + Lifes;
	} 

	public static void RemovePoints (int PointsToRemove) {
		Lifes -= PointsToRemove;

	}

	public static void AddPoints (int PointsToAdd) {
		Lifes += PointsToAdd;

	}
}

