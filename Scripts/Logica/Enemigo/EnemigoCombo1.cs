using UnityEngine;
using System.Collections;
using System;

public class EnemigoCombo1 : EnemigoCombo {

	// Public variable that contains the speed of the enemy
	public int combo = 1;
	public bool comp = false;
	public bool comp2 = false;


	public void mataCombo (){

		NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", 1);
		Destroy (gameObject);
	}

	void Update(){



	}

}