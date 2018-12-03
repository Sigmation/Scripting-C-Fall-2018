using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* this give you more lines
1
2
3
4
 */

public class CharacterMove : MonoBehaviour {

	//Player Movement Variables
	public int MoveSpeed;
	public float JumpHeight;
	private bool SecondJump;

	//Player grounded varilbles 
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	public bool Grounded;

	//non-stick player?
	private float MoveVolocity;

	// Use this for initialization
	void Start () {
		print("Hello World!");
	}

	//Defines Ground
	void FixedUpdate () {
	Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);

	}
	// Update is called once per frame
	void Update(){


		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
			
		}
		//double jump code
		if(Grounded)
			SecondJump = false;
		
		if(Input.GetKeyDown (KeyCode.Space)&& !SecondJump && !Grounded){
			Jump();
			SecondJump = true;
		}
		//non-stick player?
		MoveVolocity = 0f;

		//this code makes the character move left and right
		if(Input.GetKey  (KeyCode.D)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>(). velocity.y);
			MoveVolocity = MoveSpeed;
		}

		if(Input.GetKey  (KeyCode.A)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>(). velocity.y);
			MoveVolocity = -MoveSpeed;

		}
	
		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVolocity, GetComponent<Rigidbody2D>(). velocity.y);

		//player flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(5f,5f,1);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-5f,5f,1);
			
		}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}

		
}
