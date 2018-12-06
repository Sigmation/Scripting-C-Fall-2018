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

	public int Crack;
	public int Crack2;
	public int Broke;
	public int Reset;
	//makes it work with multiple barrles

	// Use this for initialization
	void Start () {
		Barrle2.GetComponent<Renderer>() .enabled = false;
		
		Damage = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(Damage == Crack){
			Barrle1.GetComponent<Renderer>() .enabled = false;
			Barrle2.GetComponent<Renderer>() .enabled = true;
		}
		if(Damage == Crack2){
		Instantiate(BrakeParticle, Barrle1.transform.position, Barrle1.transform.rotation);
		Damage = Damage + 1;
		}
		if(Damage == Broke){
			Instantiate(Inside,DropPoint.position, DropPoint.rotation);
			Damage = Reset;
			Destroy (gameObject);

		}
	}
	
	

}
