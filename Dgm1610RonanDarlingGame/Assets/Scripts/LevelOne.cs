using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelOne : MonoBehaviour {

	
	public float LevelWin;
	public Text LevelText;
	public GameObject WinParticle;
	public GameObject Player;
	
	void Start(){
		LevelText.GetComponent<Text>().enabled = false;
	}

	void OnTriggerEnter2D (Collider2D other){
		StartCoroutine ("VictoryCo");
		}

		public IEnumerator VictoryCo(){
			Sign.WichLevel = 1;
			LevelText.GetComponent<Text>().enabled = true;
			Player.SetActive(false);
			Instantiate(WinParticle, LevelText.transform.position, LevelText.transform.rotation);
			yield return new WaitForSeconds (LevelWin);
			SceneManager.LoadScene(1);
		}
		
}