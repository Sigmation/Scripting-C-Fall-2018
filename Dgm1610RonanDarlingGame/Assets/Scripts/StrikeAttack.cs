using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrikeAttack : MonoBehaviour {
	
	public GameObject Strike;
	public Transform SuperCheck;
	public float Pause;

	// Use this for initialization
	void Start () {
		StartCoroutine ("StrikeAttackCo");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public IEnumerator StrikeAttackCo(){
		yield return new WaitForSeconds (Pause);
		Instantiate(Strike, SuperCheck.position, SuperCheck.rotation);
		Destroy (gameObject);
	}
}
