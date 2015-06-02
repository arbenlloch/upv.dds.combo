using UnityEngine;
using System.Collections;
using System;
public class DecoradorCoinOne : Decorador{

	private bool controlItemOne;
	GameObject combo1Clonado;
	EnemigoCombo enemigoComboComponente;
	
	public DecoradorCoinOne(PlayerDDS pl) : base(pl){
		Debug.Log ("Construyendo un DecoradorCoinOne");
	}

	public override void  funcionalidad(){
		
		base.funcionalidad();
		Debug.Log ("MataComboEnfuncionalidad");
		this.addMataCombo();
	}

	public void addMataCombo(){

		GameObject jugador = GameObject.Find ("triangulo");
		PlayerController playerDecorandose = jugador.GetComponent<PlayerController>();
//		combo1Clonado = GameObject.Find ("combo1(Clone)");

		if (playerDecorandose.getControlBalaDestruida()) {
			Debug.Log ("En addMatacombo el player tiene la moneda esta activa "+playerDecorandose.getMonedaUnoEstado ());
			Debug.Log ("En addMatacombo el enemigo combo tiene la moneda: " + playerDecorandose.getControlBalaDestruida());

//			enemigoComboComponente.OnTriggerEnter2D(bala.collider2D);
			Debug.Log ("MatandoComboEnfuncionalidadEnaddMataCombo");
			GameObject.Destroy (GameObject.Find ("combo1(Clone)"));
		}
	}
	
	public void setControlItemOne(bool itemOne){
		this.controlItemOne = itemOne;
	}

	void encuentraEnemigo(){
	
	combo1Clonado = GameObject.FindGameObjectWithTag("ECombo1");
	Debug.Log("Enemigo activo en jerarquia: " + controlItemOne);
		if (combo1Clonado.gameObject.activeInHierarchy) {
			this.controlItemOne = true;
			Debug.Log("Enemigo activo en jerarquia: " + controlItemOne);
		}
	}
}