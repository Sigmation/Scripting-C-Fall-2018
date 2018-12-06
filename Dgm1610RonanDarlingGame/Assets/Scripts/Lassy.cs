using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lassy : MonoBehaviour {
	public float TimeOut;
	// Use this for initialization
	void Start () {
		Destroy (gameObject,TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
