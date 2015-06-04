using UnityEngine;
using System.Collections;
using System;
public class DecoradorCoinOne : Decorador{

	private bool controlItemOne;
	GameObject combo1Clonado;
	EnemigoCombo enemigoComboComponente;
	GameObject jugador;
	PlayerController playerDecorandose;
	
	public DecoradorCoinOne(PlayerDDS pl) : base(pl){
		jugador = GameObject.Find ("triangulo");
		playerDecorandose = jugador.GetComponent<PlayerController>();
	}

	public override void  funcionalidad(){
		
		base.funcionalidad();
		this.addMataCombo();
	}

	public void addMataCombo(){
		Debug.Log ("Estoy dentro de addMataCombo");

//		combo1Clonado = GameObject.Find ("combo1(Clone)");
		Debug.Log ("Estado del decorador, matando combo con ControlBalaDentruida " + playerDecorandose.getControlBalaDestruida());
		if (playerDecorandose.getControlBalaDestruida()) {
			combo1Clonado = GameObject.Find("combo1(Clone)");
			GameObject.Destroy (combo1Clonado);
			playerDecorandose.setControlBalaDestruida(false);
		}
	}
	
	public void setControlItemOne(bool itemOne){
		this.controlItemOne = itemOne;
	}

	void encuentraEnemigo(){
	
	combo1Clonado = GameObject.FindGameObjectWithTag("ECombo1");
		if (combo1Clonado.gameObject.activeInHierarchy) {
			this.controlItemOne = true;
		}
	}
}