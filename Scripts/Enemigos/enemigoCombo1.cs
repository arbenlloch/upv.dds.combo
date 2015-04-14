using UnityEngine;
using System.Collections;
using System;


public class enemigoCombo1 : enemigoCombo {

	// Public variable that contains the speed of the enemy
	public int combo = 1;

	void Update(){
		//destruir combo1 con la letra Q + M + G (pulsadas)
		if (Input.GetKey ("q"))
		    if(Input.GetKey ("m"))
				if(Input.GetKeyDown("g"))
				Destroy (gameObject);
	}

}
