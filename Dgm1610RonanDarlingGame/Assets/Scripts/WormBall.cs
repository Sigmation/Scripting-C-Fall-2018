using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormBall : MonoBehaviour {


	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	public bool Grounded;
	public GameObject WormSpawn;
	public Transform DropWorm;
	public int partciless;
	public GameObject WormParticle;
	public BossIndicate BossIndicate;
	// Use this for initialization
	void Start () {
		
	}
	void FixedUpdate () {
	Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);
	BossIndicate = FindObjectOfType <BossIndicate>();

	}
	// Update is called once per frame
	void Update () {
		if(Grounded){
			Instantiate(WormSpawn,DropWorm.position, DropWorm.rotation);
			partciless = 1;

		}
		if(partciless == 1){
			Instantiate(WormParticle,DropWorm.position, DropWorm.rotation);
			BossIndicate.DestoeySelf();
			Destroy (gameObject);
		}
	}
}
