using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class LevelManager : MonoBehaviour {
 
	public GameObject CurrentCheckPoint;
	private Rigidbody2D Player;

	//particles
	public GameObject DeathParticle;
	public GameObject RespawnParticle;

	//Respawn Delay
	public float RespawnDelay;

	//Point Penalty On Death
	public int DeathPenalty;

	//Stores Gravity
	private float StoreGravity;

	//Use this for ininsalising
	void Start () {
		//Player = FindObjectOfType<Rigidbody2D> ();
		DeathParticle = GameObject.Find("DeathParticle");
		RespawnParticle = GameObject.Find("RespawnParticle");
	
	}
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Creates death particle
		Instantiate (DeathParticle, Player.transform.position, Player.transform.rotation);
		//hide player
		//Player.enable = false;
		Player.GetComponent<Renderer>() .enabled = false;
		// Gravity reset
		StoreGravity = Player.GetComponent<Rigidbody2D>().gravityScale;
		Player.GetComponent<Rigidbody2D>().gravityScale =0f;
		Player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//point penalty
		ScoreManager.AddPoints(-DeathPenalty);
		//Debug Penailty
		Debug.Log("Player Respawn");
		yield return new WaitForSeconds (RespawnDelay);
		Player.GetComponent<Rigidbody2D>().gravityScale = StoreGravity;
		Player.transform.position = CurrentCheckPoint.transform.position;
		Player.GetComponent<Renderer>() .enabled = true;
		Instantiate (RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);

		}
}
