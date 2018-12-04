using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LassoCleanUp : MonoBehaviour {
	public float TimeOut;
	public GameObject EnemyDeath;
	// Use this for initialization
	void Start () {
		EnemyDeath = Resources.Load("Prefab/DeathParticle") as GameObject;
		
		Destroy (gameObject,TimeOut);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
		void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Enemy"){
			Instantiate(EnemyDeath, other.transform.position, other.transform.rotation);
			Destroy (other.gameObject);
		}
}
}
