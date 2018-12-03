using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class Shop : MonoBehaviour {
	public Text ShopText;
	GameObject Select;
	public int Buy;
	public GameObject Cheat;
	public int Cheater;
	
	// Use this for initialization
	void Start () {
		ShopText.GetComponent<Text>();
		 ShopText.text = "Welcome To My Shop What Would You Like To Buy?";
	}

	// Update is called once per frame
	void Update () {
		if (Buy > 3)
		    Buy = 3;

		if (Buy < 1)
		    Buy = 1;

		if(Input.GetKeyDown  (KeyCode.D)){
			Buy = Buy + 1 ;
		}

		if(Input.GetKeyDown  (KeyCode.A)){
			Buy = Buy - 1 ;
		}

		if(Buy == 1){
		transform.localPosition = new Vector3(1.56f,2.29f,1f);

		if(Input.GetKeyDown  (KeyCode.Return)&& ScoreManager.Score == 100){
			ShopText.text = "YouWin";
			ScoreManager.Score = ScoreManager.Score - 100;
		}
		else if(Input.GetKeyDown  (KeyCode.Return)&& ScoreManager.Score < 100){
			ShopText.text = "You Want To Win The Game Alredy? To Bad You Lack The Funds. But I Here By Beating The Boss On The 3rd Level You Get 100 Gold";
		}
		}
		else if (Buy == 2){
		transform.localPosition = new Vector3(3.42f,2.29f,1f);
			if(Input.GetKeyDown  (KeyCode.Return)){
			ShopText.text = "Whoa There You Are Way To Young For That Stuff!";
			}
		}
		else if (Buy == 3){
		transform.localPosition = new Vector3(5.5f,2.46f,1f);
			if(Input.GetKeyDown  (KeyCode.Return)&& ScoreManager.Score == 50 && Cheater == 0){
			ShopText.text = "Congrats The First Phase Of The Boss Has Been Skiped";
			ScoreManager.Score = ScoreManager.Score - 50;
			Cheater = 1;
			}
			else if(Input.GetKeyDown  (KeyCode.Return)&& ScoreManager.Score < 50 && Cheater == 0){
			ShopText.text = "Ah Yes The Cow Skull. What Does It Do You Ask? Why It Skips One Of The Bosses Phase's For You. It Looks Like You Dont Have Enough Come Back When You Have 50 Gold";
			}
		else if(Input.GetKeyDown  (KeyCode.Return)&& Cheater == 1){
			ShopText.text = "You Already Bought This!!!";
			}
			}
		if(Cheater == 1){
			Destroy (Cheat);
		}
		 
		
		if(Input.GetKeyDown(KeyCode.Escape)){
			 SceneManager.LoadScene(1);
		 }
	}
}