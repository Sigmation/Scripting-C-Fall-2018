using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lasso : MonoBehaviour {

	public GameObject Pc;
	public Transform FirePoint;
	public Transform FirePoint2;
	public GameObject Laso;
	public GameObject Laso2;
	public float LassoDelay;
	public float Pause;
	

	// Use this for initialization
	void Start () {
		Pc = GameObject.Find("Pc");
		Laso = Resources.Load("Prefab/lasso") as GameObject;
		Laso2 = Resources.Load("Prefab/lasso2") as GameObject;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Pc.transform.localScale.x < 0)
			Laso.transform.localScale = new Vector3(-0.4f,0.3f,1);
		else 
			Laso.transform.localScale = new Vector3(0.4f,0.3f,1);
		if(Pc.transform.localScale.x < 0)
			Laso2.transform.localScale = new Vector3(-0.4f,0.3f,1);
		else 
			Laso2.transform.localScale = new Vector3(0.4f,0.3f,1);
		if(Input.GetKeyDown(KeyCode.LeftControl)){
			StartCoroutine ("LassoCo");
			}
			
	}
		public IEnumerator LassoCo(){
			Instantiate(Laso2,FirePoint2.position, FirePoint2.rotation);
			yield return new WaitForSeconds (Pause);
			Instantiate(Laso,FirePoint.position, FirePoint.rotation);
		}
	

	}
