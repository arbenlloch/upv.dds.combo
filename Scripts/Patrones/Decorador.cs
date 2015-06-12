using UnityEngine;
using System.Collections;
using System;

public abstract class Decorador : PlayerController{

	public GameObject jugador;
	protected PlayerController player;

	public Decorador(PlayerController pla){

		this.player = pla;
	}

	public override void funcionalidad(){
		player.funcionalidad ();
	}
}