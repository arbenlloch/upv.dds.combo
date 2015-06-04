using UnityEngine;
using System.Collections;
using System;
public class DecoradorCoinOne : Decorador{
	
	private bool controlItemOne;
	GameObject combo1Clonado;
	EnemigoCombo enemigoComboComponente;
	
	public DecoradorCoinOne(PlayerDDS pl) : base(pl){
		
	}
	
	public override void  funcionalidad(){
		
		base.funcionalidad();
		this.addMataCombo();
	}
	
	public void addMataCombo(){
		
		GameObject jugador = GameObject.Find ("triangulo");
		PlayerController playerDecorandose = jugador.GetComponent<PlayerController>();
		//		combo1Clonado = GameObject.Find ("combo1(Clone)");
		Debug.Log ("Estado del decorador, matando combo con ControlBalaDentruida " + playerDecorandose.getControlBalaDestruida());
		if (playerDecorandose.getControlBalaDestruida()) {
			
			GameObject.Destroy (GameObject.Find ("combo1(Clone)"));
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