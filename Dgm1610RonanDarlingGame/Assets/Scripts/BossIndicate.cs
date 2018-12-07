using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossIndicate : MonoBehaviour {

	public static int Destoy;

void Update(){
	if(Destoy == 1)
	Destroy (gameObject);
	Destoy = 0;
}
public void DestoeySelf() {
	Destoy = 1;
}
}
