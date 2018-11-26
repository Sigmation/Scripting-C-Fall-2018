using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class LevelManager : MonoBehaviour {
	
	public GameObject CurrentCheckPoint;
	private Rigidbody2D Pc;
	public int PointsToRemove;
	public GameObject Pc2;
	public Text OutOflifes;
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
		Pc = FindObjectOfType<Rigidbody2D> ();
		OutOflifes = FindObjectOfType<Text> ();
		OutOflifes.enabled = false;
	
	} 
	public void RespawnPlayer(){
		StartCoroutine ("RespawnPlayerCo");
	}

	public IEnumerator RespawnPlayerCo(){
		//Creates death particle
		Instantiate(DeathParticle, Pc.transform.position, Pc.transform.rotation);
		//hide player
		//Player.enable = false;
		Pc2.SetActive(false);
		Pc.GetComponent<Renderer>() .enabled = false;
		LifeCount.RemovePoints (PointsToRemove);
		// Gravity reset
		StoreGravity = Pc.GetComponent<Rigidbody2D>().gravityScale;
		Pc.GetComponent<Rigidbody2D>().gravityScale =0f;
		Pc.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		//point penalty
		ScoreManager.AddPoints(-DeathPenalty);
		//Debug Penailty
		Debug.Log("Player Respawn");
		yield return new WaitForSeconds (RespawnDelay);
		Pc.GetComponent<Rigidbody2D>().gravityScale = StoreGravity;
		Pc.transform.position = CurrentCheckPoint.transform.position;
		Pc2.SetActive(true);
		Pc.GetComponent<Renderer>() .enabled = true;
		Instantiate(RespawnParticle, CurrentCheckPoint.transform.position, CurrentCheckPoint.transform.rotation);
		if (LifeCount.Lifes == 0)
		OutOflifes.enabled = true;
	}
			

	
}
