using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopDoor : MonoBehaviour {

	public GameObject Indicator;
	public bool IsAtDoor;
	// Use this for initialization

	void Start () {
		Indicator.GetComponent<Renderer>() .enabled = false;
		IsAtDoor = false;
	}
	
	// Update is called once per frame
	void Update () {
			if(Input.GetKeyDown(KeyCode.W)&& IsAtDoor)
			 SceneManager.LoadScene(2);
	}
		void OnTriggerEnter2D (Collider2D other){
			transform.localScale = new Vector3(0.5013887f,0.4867187f,1f);
			Indicator.GetComponent<Renderer>() .enabled = true;
			IsAtDoor = true;
		
		}
		void OnTriggerExit2D (Collider2D other){
		transform.localScale = new Vector3(0.4407813f,0.4375f,1f);
		Indicator.GetComponent<Renderer>() .enabled = false;
		IsAtDoor = false;
		}
}
