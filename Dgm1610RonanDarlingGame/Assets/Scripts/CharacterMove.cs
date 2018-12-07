using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
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

	public Animator animator;

	public float JumpDeley;
	// Use this for initialization
	void Start () {
		print("Hello World!");
		animator.SetBool("IsWalking", false);
		animator.SetBool("IsJumping", false);
		animator.SetBool("IsAttacking", false);
	}

	//Defines Ground
	void FixedUpdate () {
	Grounded = Physics2D.OverlapCircle(GroundCheck.position, GroundCheckRadius, WhatIsGround);

	}
	// Update is called once per frame
	void Update(){

		if(Input.GetKeyDown(KeyCode.Escape)){
			 SceneManager.LoadScene(0);
		 }
		if(Input.GetKey (KeyCode.LeftControl)){
			animator.SetBool("IsAttacking", true);
		}
		else if(Input.GetKeyUp (KeyCode.LeftControl)){
			animator.SetBool("IsAttacking", false);
		}

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
			animator.SetBool("IsWalking", true);
			
		}
		else if(Input.GetKeyUp(KeyCode.D)){
			animator.SetBool("IsWalking", false);
		}
		if(Input.GetKey  (KeyCode.A)){
			//GetComponent<Rigidbody2D>().velocity = new Vector2(-MoveSpeed, GetComponent<Rigidbody2D>(). velocity.y);
			MoveVolocity = -MoveSpeed;
			animator.SetBool("IsWalking", true);
		}
		else if(Input.GetKeyUp(KeyCode.A)){
			animator.SetBool("IsWalking", false);
		}
		GetComponent<Rigidbody2D>().velocity = new Vector2(MoveVolocity, GetComponent<Rigidbody2D>(). velocity.y);

		//player flip
		if (GetComponent<Rigidbody2D>().velocity.x > 0)
			transform.localScale = new Vector3(0.3f,0.3f,1);

		else if (GetComponent<Rigidbody2D>().velocity.x < 0)
			transform.localScale = new Vector3(-0.3f,0.3f,1);
			
		}

	public void Jump(){
		GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, JumpHeight);
		StartCoroutine ("JumpCo");
	}
	public IEnumerator JumpCo(){
		animator.SetBool("IsJumping", true);
		yield return new WaitForSeconds (JumpDeley);
		animator.SetBool("IsJumping", false);
	}
		
}
