using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopDoor : MonoBehaviour {

	public GameObject Indicator;
	// Use this for initialization
	void Start () {
		Indicator.GetComponent<Renderer>() .enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		void OnTriggerEnter2D (Collider2D other){
			transform.localScale = new Vector3(0.5013887f,0.4867187f,1f);
			Indicator.GetComponent<Renderer>() .enabled = true;
		}
				void OnTriggerStay2D (Collider2D other){
			if(Input.GetKeyDown(KeyCode.W)){
			 SceneManager.LoadScene(2);
		}
		}
		void OnTriggerExit2D (Collider2D other){
		transform.localScale = new Vector3(0.4407813f,0.4375f,1f);
		Indicator.GetComponent<Renderer>() .enabled = false;
		}
}
