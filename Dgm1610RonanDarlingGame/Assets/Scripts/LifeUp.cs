using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeUp : MonoBehaviour {

	public int PointsToAdd;

	void OnTriggerEnter2D (Collider2D other){
		if(other.GetComponent<Rigidbody2D>() == null)
			return;
		LifeCount.AddPoints (PointsToAdd);

		Destroy (gameObject);
	}
}
