using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class LifeCount : MonoBehaviour {

public static int Lifes = 3;

	Text LifesCount;
	

	// Use this for initialization
	void Start () {

	

		LifesCount = GetComponent<Text>();

		 
		}
	
	// Update is called once per frame
	void Update () {
		if (Lifes < 0)
		    Lifes = 0;
			
		LifesCount.text = " " + Lifes;
		if (Lifes == 0){
			SceneManager.LoadScene(4);
		}
	} 

	public static void RemovePoints (int PointsToRemove) {
		Lifes -= PointsToRemove;

	}

	public static void AddPoints (int PointsToAdd) {
		Lifes += PointsToAdd;

	}

	
}

