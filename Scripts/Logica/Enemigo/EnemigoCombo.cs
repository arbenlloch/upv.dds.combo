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
	
	public int speed = -5;

	void Start(){
		rigidbody2D.velocity = new Vector2(speed,0);
		player = GameObject.Find ("triangulo");
		playerControl = player.GetComponent<PlayerController>();
		Destroy(gameObject, 7);
	}


	public void OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;
		if (name == "bullet(Clone)") {
			this.itemCoinUno = true;
			Debug.Log("El control de bala destruida es: "+itemCoinUno);
			if(playerControl.getMonedaUnoEstado()){
				playerControl.setControlBalaDestruida(itemCoinUno);
			}
			Destroy (obj.gameObject);
		}

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