using UnityEngine;
using System.Collections;

public class ItemCoin : MonoBehaviour
{	
	public ItemCoin(){

	}

	public int speed = -5;

	// Use this for initialization
	void Start ()
	{
		rigidbody2D.velocity = new Vector2 (speed, 0);
		Destroy(gameObject, 7);
	}

	void OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;
		
		if (name == "triangulo") {
			//Desturye el ItemCoin
			Destroy (gameObject);
			//Lanzamos Gameover

		}
		
		/*if (name == "bullet(Clone)") {
			//Desturye Bala o el jugador
			Destroy(obj.gameObject);
		}*/
		
	}
}