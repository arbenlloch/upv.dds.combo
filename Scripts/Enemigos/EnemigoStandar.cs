﻿using UnityEngine;
using System.Collections;

public class EnemigoStandard : Enemigo
{
	public EnemigoStandard(){
		
	}
	
	// Use this for initialization
	void Start ()
	{
		Destroy(gameObject, 7);
	}
	
	void OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;
		
		if (name == "bullet(Clone)" || name == "triangulo") {
			//Desturye EnemigoStandard
			Destroy(gameObject);
			//Desturye Bala o el jugador
			Destroy(obj.gameObject);
		}
	}
}