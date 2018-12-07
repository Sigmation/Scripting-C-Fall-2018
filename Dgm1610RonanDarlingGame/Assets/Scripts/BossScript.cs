using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour {

	public Slider Health;
	public Animator animator;
    public float idol;
	public float spit;
	public int Attacks = 1;
	public GameObject SpitBall;
	public Transform Drop1;
	public Transform Drop2;
	public bool SpAttack;
	private Coroutine coroutine;
	public Transform Attack2drop;
	public GameObject HeadAttack;
	public GameObject Warms;
	public GameObject SGround;
	public GameObject Head1;
	public GameObject Head2;
	public float Hethl;
	public GameObject Star;
	public GameObject Defeat;
	public float Hethler;
	public float LevelWin;
	public Text BossText;
	public GameObject WinParticle;
	public static int SkeCheat;
	public GameObject Cheat;
	public Transform Ceet;
	public GameObject Chaat;

	// Use this for initialization
	void Start () {
		animator.SetBool("IsSpitting", false);
		SpAttack = false;
		coroutine = StartCoroutine(SpitAttackCo());
		Star.GetComponent<Renderer>() .enabled = false;
		Defeat.GetComponent<Renderer>() .enabled = false;
		BossText.GetComponent<Text>().enabled = false;
		Chaat.GetComponent<Renderer>().enabled = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		

		if(SkeCheat == 1){
		Chaat.GetComponent<Renderer>().enabled = true;
		Instantiate(Cheat, Ceet.position, Ceet.rotation);
		Health.value = Hethl;
		SkeCheat = 0;
		return;
		}


		if(SpAttack){
			Instantiate(SpitBall, Drop1.position, Drop1.rotation);
			Instantiate(SpitBall, Drop2.position, Drop2.rotation);
			StopCoroutine(coroutine);
			StartCoroutine ("HeadAttackCo");
			SpAttack = false;
			return;
			
		}
		
	}
		public void Damagedd(){
			if(Health.value == Hethl){
			Health.value = Hethler;
			Star.GetComponent<Renderer>() .enabled = true;
			Defeat.GetComponent<Renderer>() .enabled = true;
			Instantiate(WinParticle, BossText.transform.position, BossText.transform.rotation);
			BossText.GetComponent<Text>().enabled = true;
			StartCoroutine ("BoddWinCo");
			}
			else{
			Health.value = Hethl;
			SpitAttack();
			}
		}

		public void SpitAttack(){
		StartCoroutine ("SpitAttackCo");
	}
	public IEnumerator SpitAttackCo(){
		Warms.GetComponent<Renderer>() .enabled = true;
		SGround.GetComponent<Renderer>() .enabled = true;
		Head1.GetComponent<Renderer>() .enabled = true;
		Head2.GetComponent<Renderer>() .enabled = true;
		yield return new WaitForSeconds (idol);
		animator.SetBool("IsSpitting", true);
		Chaat.GetComponent<Renderer>().enabled = false;
		yield return new WaitForSeconds (spit);
		animator.SetBool("IsSpitting", false);
		SpAttack = true;	
		
	}
		public IEnumerator HeadAttackCo(){
		yield return new WaitForSeconds (idol);
		Instantiate(HeadAttack, Attack2drop.position, Attack2drop.rotation);
		Warms.GetComponent<Renderer>() .enabled = false;
		SGround.GetComponent<Renderer>() .enabled = false;
		Head1.GetComponent<Renderer>() .enabled = false;
		Head2.GetComponent<Renderer>() .enabled = false;
	}
	public IEnumerator BoddWinCo(){
		Sign.WichLevel = 3;
		ScoreManager.Score = 100;
		yield return new WaitForSeconds (LevelWin);
		SceneManager.LoadScene(1);

	}
}