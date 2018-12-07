using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillerCollider : MonoBehaviour {
	
	public WormStrikeAttack WormStrikeAttack;
	// Use this for initialization
	void Start () {
		WormStrikeAttack = FindObjectOfType <WormStrikeAttack>();
	}
	
void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "BigWorm"){
			WormStrikeAttack.Hurt = true;
			Destroy (gameObject);
			return;
		}
}
}