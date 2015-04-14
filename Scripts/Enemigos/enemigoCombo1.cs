using UnityEngine;
using System.Collections;
using System;


public class enemigoCombo1 : enemigoCombo {

	// Public variable that contains the speed of the enemy
	public int combo = 1;
	public bool comp = false;
	public bool comp2 = false;

	void Update(){
		//destruir combo1 con la letra Q + M + G (pulsadas)

		if (Input.GetKeyDown ("q")) 
			comp = true;

		if (comp == true && Input.GetKeyDown ("m")) 
				comp2 = true;

		if (comp == true && comp2 == true && Input.GetKeyDown ("g"))
					Destroy (gameObject);
		
		 
	}

}
