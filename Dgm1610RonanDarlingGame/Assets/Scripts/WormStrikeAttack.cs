using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormStrikeAttack : MonoBehaviour {

	public float Wait;
	public float LessWait;
	public BossScript BossScript;
	public static bool Hurt;

	// Use this for initialization
	void Start () {
		BossScript = FindObjectOfType <BossScript>();
		Hurt = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Hurt){
		Hurt = false;
		StartCoroutine ("SAttacksCo");
		}
		else
		StartCoroutine ("BAttacksCo");
	}
	
public IEnumerator SAttacksCo(){
		yield return new WaitForSeconds (LessWait);
		BossScript.Damagedd();
		Destroy (gameObject);
	}

	public IEnumerator BAttacksCo(){
		yield return new WaitForSeconds (Wait);
		BossScript.SpitAttack();
		Destroy (gameObject);
	}
}
