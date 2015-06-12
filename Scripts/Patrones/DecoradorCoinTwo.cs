using UnityEngine;
using System.Collections;
using System;

public class DecoradorCoinTwo : Decorador{
	
	private bool controlItemOne;
	GameObject combo1Clonado;
	EnemigoCombo enemigoComboComponente;
	GameObject playerAux;
	PlayerController playerControllerAux;
	
	public DecoradorCoinTwo(PlayerController pl) : base(pl){
	}
	
	public override void  funcionalidad(){
		//A causa de la llamada a la funcionalidad original a traves del patron comando. Esta estara siempre presente
		//y no necesitara llamarse explicitamente.
		this.addBalaGrande();
	}
	
	public void addBalaGrande(){
		playerAux = GameObject.Find ("triangulo");
		playerControllerAux = playerAux.GetComponent<PlayerDDS>();
		if (playerControllerAux.getMonedaDosEstado()) {
			playerControllerAux.bala.transform.localScale = new Vector3 (6,12,2);
		}
	}
	
	public void setControlItemOne(bool itemOne){
		this.controlItemOne = itemOne;
	}
}