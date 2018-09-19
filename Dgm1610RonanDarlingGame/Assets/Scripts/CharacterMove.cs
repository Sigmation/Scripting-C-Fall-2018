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
	
	//Player grounded varilbles 
	public Transform GroundCheck;
	public float GroundCheckRadius;
	public LayerMask WhatIsGround;
	public bool Grounded;

	// Use this for initialization
	void Start () {
		print("Hello World!");
	}
	
	void fixedupdate () {
	Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);

	}
	// Update is called once per frame
	void Update(){

        //this code makes the character jump
		if(Input.GetKeyDown (KeyCode.Space)&& Grounded){
			Jump();
		}

		//this code makes the character move left and right
		if(Input.GetKeyDown  (KeyCode.D)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(MoveSpeed, GetComponent<Rigidbody2D>(). velocity.y);
		
		}
		if(Input.GetKeyDown  (KeyCode.A)){
			GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>(). velocity.y);
		
		}
    }
	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
	}
}
