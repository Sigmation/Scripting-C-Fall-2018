using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {

	public float Speed;
	public GameObject Pc;
	public GameObject EnemyDeath;
	public GameObject PorjectileParticle;
	public int PointsForKill;
	public int TimeOut;

	// Use this for initialization
	void Start () {
		Pc = GameObject.Find("Pc");

		EnemyDeath = Resources.Load("Prefab/DeathParticle") as GameObject;

		PorjectileParticle = Resources.Load("Prefab/DeathParticle") as GameObject;

		if(Pc.transform.localScale.x < 0)
			Speed = -Speed;

		
		
		Destroy (gameObject,TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
		GetComponent<Rigidbody2D>().velocity = new Vector2(Speed, GetComponent<Rigidbody2D>().velocity.y);
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
			ScoreManager.AddPoints (PointsForKill);
		}


		Destroy (gameObject);
	}
	void OnCollisionEnter2D(Collision2D other){
		Instantiate(PorjectileParticle, transform.position, transform.rotation);
		Destroy (gameObject);
	}
	
}
