using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switches : MonoBehaviour {

	//public int Num = 10;
	public string Name;
	// Use this for initialization
	void Start () {
		
	//	if(Num == 10)
//			print("Hurray you picked " + Num);
		
	//	else
	//		print("Boo you suck at picking 10");

	//	switch(Num){

	//		case 1:
	//			print("you picked " + Num);
	//		break;

//			case 3:
//				print("you picked " + Num);
//			break;

//			case 6:
//				print("you picked " + Num);
//			break;

//			case 9:
//				print("you picked " + Num);
//			break;

//			default:
//				print("i dont understand " + Num);
//			break;
//		}

		switch(Name){
			case "Jason":
				print("Welocome to camp crystal lake " + Name + " Love Mother");
			break;

			case "Michael":
				print("Welocome to houndfiled III " + Name);
			break;

			case "Freddy":
				print("Welocome to Elm Street " + Name);
			break;

			case "Leatherface":
				print("the stars and stripes are big at night... Deep in the heart of texas");
			break;

			default:
				print("I dont know " + Name);
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
