using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sign : MonoBehaviour {

	public static int WichLevel;

	void OnTriggerEnter2D (Collider2D other){
		if (WichLevel == 0)
		SceneManager.LoadScene(3);

		if (WichLevel == 1)
		SceneManager.LoadScene(5);
		
		if (WichLevel == 2)
		SceneManager.LoadScene(6);
		}
		
}
