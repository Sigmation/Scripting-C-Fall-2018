using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class AmmoManager : MonoBehaviour {

public static int Ammo;

	Text AmmoCount;

	// Use this for initialization
	void Start () {
		AmmoCount = GetComponent<Text>();

		Ammo = 20;
	}
	
	// Update is called once per frame
	void Update () {
		if (Ammo > 20)
			Ammo = 20;
		if (Ammo < 0)
		    Ammo = 0;
		AmmoCount.text = " " + Ammo;
	} 

	public static void RemovePoints (int PointsToRemove) {
		Ammo -= PointsToRemove;

	}

	public static void AddPoints (int PointsToAdd) {
		Ammo += PointsToAdd;

	}
}
