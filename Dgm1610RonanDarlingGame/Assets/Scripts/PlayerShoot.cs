﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	
	public int PointsToRemove;
	// Shoot varible
	public Transform FirePoint;
	public GameObject Projectile;

	// Use this for initialization
	void Start () {
		Projectile = Resources.Load("Prefab/Projectile") as GameObject;
		//Projectile = GameObject.Find("Projectile");
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.LeftControl)&& AmmoManager.Ammo > 0){
			AmmoManager.RemovePoints (PointsToRemove);
			Instantiate(Projectile,FirePoint.position, FirePoint.rotation);	
			
		}
	}
}
