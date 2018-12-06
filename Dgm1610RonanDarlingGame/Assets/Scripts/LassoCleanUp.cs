﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LassoCleanUp : MonoBehaviour {
	public float TimeOut;
	public Barrle Barrle;

	// Use this for initialization
	void Start () {
		Barrle = FindObjectOfType <Barrle>();
		Destroy (gameObject,TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
	}
		void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Bar"){
			Barrle.Damage = Barrle.Damage + 1;
			return;
		}
}
}
