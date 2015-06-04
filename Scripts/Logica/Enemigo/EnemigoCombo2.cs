using UnityEngine;
using System.Collections;

public class EnemigoCombo2 : EnemigoCombo{


	public int combo = 2;
	public bool comp = false;
	public bool comp2 = false;
	


	public void mataCombo (){
		
		NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", 1);
		Destroy (gameObject);
	}

}
