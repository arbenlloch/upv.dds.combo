using UnityEngine;
using System.Collections;
using System;
public class DecoradorCoinTwo : Decorador{
	
	private bool controlItemOne;
	GameObject combo1Clonado;
	EnemigoCombo enemigoComboComponente;
	GameObject playerAux;
	PlayerController playerControllerAux;
	
	public DecoradorCoinTwo(PlayerDDS pl) : base(pl){
		Debug.Log ("Construyendo un DecoradorCoinOne");
	}
	
	public override void  funcionalidad(){
		base.funcionalidad();
		Debug.Log ("MataComboEnfuncionalidadMoneda2");
		this.addBalaGrande();
	}
	
	public void addBalaGrande(){
		Debug.Log ("Dentro del decorado, moneda 2");
		playerAux = GameObject.Find ("triangulo");
		playerControllerAux = playerAux.GetComponent<PlayerController>();
		//playerControllerAux = playerControllerAux.GetComponent<Bala>();
		if (playerControllerAux.getMonedaDosEstado()) {
			playerControllerAux.bala.transform.localScale = new Vector3 (7,15,2);
		}
		

		//GameObject spawnAux = GameObject.Find ("spawn");
		//NaceEnemigo naceEnemigoAux = spawnAux.GetComponent<NaceEnemigo> ();

		//GameObject prefabBala = GameObject.Find ("bullet(Clone)");
		//GameObject prefabBala = (GameObject)Resources.Load("Assets/upv.dds.combo/Prefabs/bullet");
	    //Bala balaPropiedad= prefabBala.GetComponent<Bala>();
		//prefabBala.transform.localScale = new Vector3 (5, 15, 2);
		//		combo1Clonado = GameObject.Find ("combo1(Clone)");

		//if (playerDecorandose.getControlBalaDestruida()) {
			//Debug.Log ("En addMatacombo el player tiene la moneda esta activa "+playerDecorandose.getMonedaUnoEstado ());
			//Debug.Log ("En addMatacombo el enemigo combo tiene la moneda: " + playerDecorandose.getControlBalaDestruida());
			
			//			enemigoComboComponente.OnTriggerEnter2D(bala.collider2D);
			//Debug.Log ("MatandoComboEnfuncionalidadEnaddMataCombo");
			//GameObject.Destroy (GameObject.Find ("combo1(Clone)"));
		//}
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