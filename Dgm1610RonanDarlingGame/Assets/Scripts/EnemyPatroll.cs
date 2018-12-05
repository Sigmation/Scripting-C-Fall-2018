using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;


public class EnemyPatroll : MonoBehaviour {
	//movement
	public float MoveSpeed;
	public bool MoveRight;
	//walk cycle
	public Transform WallCheck;
	public float WallCheckRadius;
	public LayerMask WhatIsWall;
	private bool HittingWall;
	//edge check
	private bool NotAtEdge;
	public Transform EdgeCheck;
	public Transform Defeat;
	public GameObject TiedSnake;
	
	void Start () {
		TiedSnake = Resources.Load("Prefab/SnakeTied") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		NotAtEdge = Physics2D.OverlapCircle(EdgeCheck.position, WallCheckRadius, WhatIsWall);

		HittingWall = Physics2D.OverlapCircle(WallCheck.position, WallCheckRadius, WhatIsWall);
		//trun around at wall or edge
		if (HittingWall || !NotAtEdge){
			MoveRight = !MoveRight;
		}

		if (MoveRight){
			transform.localScale = new Vector3(-0.4f,0.33f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		else {
			transform.localScale = new Vector3(0.4f,0.33f,1f);
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>().velocity.y);
		}
		}
		public void TiedUp(){
			Instantiate(TiedSnake,Defeat.position, Defeat.rotation);
			Destroy (gameObject);
		}
}
