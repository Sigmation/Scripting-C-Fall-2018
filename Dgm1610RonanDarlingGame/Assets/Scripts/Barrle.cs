using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barrle : MonoBehaviour {

	public static int Damage;
	public GameObject Inside;
	public GameObject Barrle1;
	public GameObject Barrle2;
	public GameObject BrakeParticle;
	public Transform DropPoint;

	//makes it work with multiple barrles
	public int Damaged;
	public int Broke1;
	public int Broke2;
	public int reset;

	// Use this for initialization
	void Start () {
		Barrle2.GetComponent<Renderer>() .enabled = false;
		
		Damage = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Damage == Damaged){
			Barrle1.GetComponent<Renderer>() .enabled = false;
			Barrle2.GetComponent<Renderer>() .enabled = true;
		}
		if(Damage == Broke1){
		Instantiate(BrakeParticle, Barrle1.transform.position, Barrle1.transform.rotation);
		Damage = Damage + 1;
		}
		if(Damage == Broke2){
			Instantiate(Inside,DropPoint.position, DropPoint.rotation);
			Damage = reset;
			Destroy (gameObject);

		}
	}
}
