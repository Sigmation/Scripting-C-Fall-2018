using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour {

	public int PointsToAdd;
	

	void OnTriggerEnter2D (Collider2D other){
			if(other.GetComponent<Rigidbody2D>() == null)
			return;
		AmmoManager.AddPoints (PointsToAdd);

		Destroy (gameObject);
	}
}
