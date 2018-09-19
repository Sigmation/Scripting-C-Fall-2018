using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarFunc : MonoBehaviour {
    //3 variable
	public int Apples = 1;
	private bool Dogs;
	public float AppelCount;


	// Use this for initialization
	void Start () {
    }
		
	// Update is called once per frame
	void Update(){

	if(Input.GetKeyDown (KeyCode.L)){
		Apple();
	}
	}

	public void Apple(){
	}

}	
