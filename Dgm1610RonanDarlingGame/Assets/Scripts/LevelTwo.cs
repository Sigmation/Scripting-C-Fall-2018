using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelTwo : MonoBehaviour {

	public float LevelWin;
	public Text Leve2Text;
	public GameObject WinParticle;
	public GameObject Player;
	
	void Start(){
		Leve2Text.GetComponent<Text>().enabled = false;
	}

	void OnTriggerEnter2D (Collider2D other){
		StartCoroutine ("VictoryCo");
		}

		public IEnumerator VictoryCo(){
			Sign.WichLevel = 2;
			Leve2Text.GetComponent<Text>().enabled = true;
			Player.SetActive(false);
			Instantiate(WinParticle, Leve2Text.transform.position, Leve2Text.transform.rotation);
			yield return new WaitForSeconds (LevelWin);
			SceneManager.LoadScene(1);
		}
		
}