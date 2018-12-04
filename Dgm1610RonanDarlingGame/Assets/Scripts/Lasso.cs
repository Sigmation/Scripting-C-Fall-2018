using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasso : MonoBehaviour {

	public GameObject Pc;
	public Transform FirePoint;
	public GameObject Laso;
	public float LassoDelay;
	

	// Use this for initialization
	void Start () {
		Pc = GameObject.Find("Pc");
		Laso = Resources.Load("Prefab/lasso") as GameObject;

		
	}
	
	// Update is called once per frame
	void Update () {
		if(Pc.transform.localScale.x < 0)
			Laso.transform.localScale = new Vector3(-0.43f,0.48f,1);
		else 
			Laso.transform.localScale = new Vector3(0.43f,0.48f,1);
		if(Input.GetKeyDown(KeyCode.LeftControl)){
			Instantiate(Laso,FirePoint.position, FirePoint.rotation);
			}
	}
	

	}
