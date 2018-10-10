using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popquiz : MonoBehaviour {
	//2 public varibles that are intagers 
	public int Dog;
	public int Cat;

	//the total or sum
	private int Total;
	void Start(){
		Calculate(Cat,Dog);
	}
	
	//functun that calculates
	public void Calculate(int Cat, int Dog){
		Total = Cat + Dog;
		print (Total);
	}
}
