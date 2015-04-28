using UnityEngine;
using System.Collections;
using System;

public class EnemigoCombo1 : EnemigoCombo {

	// Public variable that contains the speed of the enemy
	public int combo = 1;
	public bool comp = false;
	public bool comp2 = false;

	void Update(){
		//destruir combo1 con la letra Q + M + G (pulsadas)

		if (Input.GetKeyDown ("q")) 
			comp = true;

		if (comp && Input.GetKeyDown ("m"))
				comp2 = true;

		if (comp && comp2 && Input.GetKeyDown ("g"))
					Destroy (gameObject);
	}

}

/*coger un combo = random 1-10
switch(num){
	case(1){
		if (Input.GetKeyDown ("q")) 
			comp = true;
		
		if (comp && Input.GetKeyDown ("m"))
			comp2 = true;
		
		if (comp && comp2 && Input.GetKeyDown ("g"))
			Destroy (gameObject);
	}
}
*/
