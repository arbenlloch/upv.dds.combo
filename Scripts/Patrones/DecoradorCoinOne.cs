using UnityEngine;
using System.Collections;
using System;

public class DecoradorCoinOne : Decorador{

	private bool controlItemOne;
	GameObject comboClonado;
	EnemigoCombo enemigoComboComponente;
	GameObject jugador;
	PlayerController playerDecorandose;

	public DecoradorCoinOne(PlayerController pl) : base(pl){
	}

	public override void  funcionalidad(){
		//A causa de la llamada a la funcionalidad original a traves del patron comando. Esta estara siempre presente
		//y no necesitara llamarse explicitamente.
		this.addMataCombo();
	}

	public void addMataCombo(){
		jugador = GameObject.Find ("triangulo");
		playerDecorandose = jugador.GetComponent<PlayerDDS>();
		if (playerDecorandose.getControlBalaDestruida()) {
			comboClonado = GameObject.FindWithTag("enemigoCombo");
			GameObject.Destroy (comboClonado);
			NotificationCenter.DefaultCenter ().PostNotification (this,"IncrementarPuntos", 1);
			playerDecorandose.setControlBalaDestruida(false);
		}
	}
	
	public void setControlItemOne(bool itemOne){
		this.controlItemOne = itemOne;
	}
}