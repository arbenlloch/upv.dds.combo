using UnityEngine;
using System.Collections;
using System;



public class EnemigoCombo : Enemigo {
	public static int incremento=5;
	private bool itemCoinUno;
	private bool aux2;
	PlayerController playerControl;
	GameObject player;
	

	public EnemigoCombo(){
		setNumEnemigos (getNumEnemigo()+1);
		this.itemCoinUno = false;
	}

	// Public variable that contains the speed of the enemy
	public int speed = -5;
	
	// Function called when the enemy is created
	void Start(){
		// Add a vertical speed to the enemy
		rigidbody2D.velocity = new Vector2(speed,0);
		player = GameObject.Find ("triangulo");
		playerControl = player.GetComponent<PlayerController>();
		Destroy(gameObject, 7);
	}
	/*
	void Update(){
		player = GameObject.Find ("triangulo");
		playerControl = player.GetComponent<PlayerController>();
		aux2 = playerControl.getMonedaUnoEstado();
		Debug.Log("En update de EnemigoCombo el estado de la moneda es: "+aux2);
	}
	*/

	/*private void inmunidadPlayer(bool inmPlayer, Collider2D obj ){

		if (obj.gameObject.name = "bullet(Clone)" && inmPlayer) {
			Destroy(gameObject);
		}
	}*/
	

	public void OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;

		//inmunidadPlayer(ItemCoinOne.getDestruido(),obj);

		/*if (obj.gameObject.name = "bullet(Clone)" && ItemCoinOne.getDestruido()) {
			Destroy(gameObject);
		}*/
//		Debug.Log ("Estado de la moneda en el player "+aux2);
		// If it collided with a bullet destroy the bullet
		if (name == "bullet(Clone)") {
			this.itemCoinUno = true;
			Debug.Log("El control de bala destruida es: "+itemCoinUno);
			playerControl.setControlBalaDestruida(itemCoinUno);
			Debug.Log ("Estado de la moneda en enemigoCombo "+itemCoinUno);
			//DecoradorCoinOne.TriggerEntered();
			Destroy (obj.gameObject);
		}

		// If it collided with the spaceship destroy the spaceship
		if (name == "triangulo") {
			Destroy (obj.gameObject);
			Application.LoadLevel ("Gameover");
		}
	}

	public bool getEstaActivaMonedaUno(){
		return this.itemCoinUno;
	}
	void Update(){

	}
}