using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sign : MonoBehaviour {

	public int WichLevel;

	void Start(){
		WichLevel = 1;
	}

	void OnTriggerEnter2D (Collider2D other){
		if (WichLevel == 1)
		SceneManager.LoadScene(3);
		}
		
}
