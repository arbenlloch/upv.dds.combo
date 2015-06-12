using UnityEngine;
using System.Collections;

public class EnemigoStandard : Enemigo
{
	public EnemigoStandard(){

	}
	
	void Start ()
	{
		Destroy(gameObject, 7);
	}

	void OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;

		if (name == "bullet(Clone)") {
			//Desturye Bala
			Destroy(obj.gameObject);
			//Desturye EnemigoStandard
			Destroy(gameObject);
			NotificationCenter.DefaultCenter().PostNotification(this,"IncrementarPuntos",4);

		}
		if (name == "triangulo") {
			Destroy (gameObject);
			//Desturye el jugador
			Destroy (obj.gameObject);
			//Lanzamos Gameover
			Application.LoadLevel ("Gameover");
		}
	}
}