using UnityEngine;
using System.Collections;
using System;

public class ItemCoinOne : MonoBehaviour
{	
	public ItemCoinOne(){
		this.destruido = false;
	}

	public int speed = -5;
	private bool destruido;
	private GameObject jugador;
	private PlayerController playerDecorandose;
	
	void Start ()
	{
		rigidbody2D.velocity = new Vector2 (speed, 0);
		Destroy(gameObject, 7);
	}

	public bool getDestruido(){
		return this.destruido;
	}

	public void setDestruido(bool d){
		this.destruido = d;
	}

	void  OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;
		
		if (name == "triangulo") {

			destruido = true;
			jugador = GameObject.Find ("triangulo");
			playerDecorandose = jugador.GetComponent<PlayerController>();
			playerDecorandose.setMonedaUnoEstado(destruido);
			Destroy (gameObject);
		}
	}
}