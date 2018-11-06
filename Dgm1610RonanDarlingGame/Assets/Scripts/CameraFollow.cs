using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public CharacterMove Pc;

	public bool isFollowing;

	//camera position
	public float xOffset;
	public float yOffset;

	// Use this for initialization
	void Start () {
		Pc = FindObjectOfType<CharacterMove>();

		isFollowing = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(isFollowing){
			transform.position = new Vector3(Pc.transform.position.x + xOffset, Pc.transform.position.y + yOffset, transform.position.z);
		}
	}
}
