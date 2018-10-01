using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {

//Varibles for parallax
	public float Parlax;

	private Transform CameraCheck;
	private Transform[] Layers;	
	private float CameraLax;

	// Use this for initialization
	void Start () {
		//defining CameraCheck as main camera
		CameraCheck = Camera.main.transform;
		CameraLax = CameraCheck.position.x;
		//calling for childs of the diffrent layers
		Layers = new Transform[transform.childCount];

		for (int i = 0; i < transform.childCount; i++) 
			Layers[i] = transform.GetChild(i);
	}
	
	// Update is called once per frame
	void Update () {

		float deltax = CameraCheck.position.x - CameraLax;
		transform.position += Vector3.right * (deltax * Parlax);
		CameraLax = CameraCheck.position.x;
	}
}
