using UnityEngine;
using System.Collections;
using System;

public class PlayerController : MonoBehaviour
{
	public float velocity;
	public GameObject bala;
	public GameObject balaDoble;
	public Puntuacion puntuacion;
	private float inputVertical;
	private float yVelocity;
	private bool monedaUnoEstado;
	private bool monedaDosEstado;
	private bool controlBalaDestruida;
	private bool controlItemOne;
	private bool controlItemTwo;
	private double tiempoCoinOne;
	private bool paused = false;
	GameObject coinOne;
	ItemCoinOne m;

	public PlayerController(){
		this.tiempoCoinOne = 0.0;
		this.controlItemOne = false;
	}

	//Funcionalidad que se implementara (Elemento concreto) o se decorara (DecoradorItemOne y DecoradorItemTwo)
	public virtual void funcionalidad (){
	}

	public void ReestablecerValores (){
		this.monedaUnoEstado= false;
		this.monedaDosEstado= false;
		this.controlBalaDestruida = false;
		this.controlItemOne = false;
		this.controlItemTwo = false;
	}

	public void setTiempoCoinOne( double tiempoCoinOne){
		this.tiempoCoinOne = tiempoCoinOne;
	}
	
	public double getTiempoCoinOne(){
		return this.tiempoCoinOne;
	}

	public void setMonedaUnoEstado( bool estadoMoneda){
		this.monedaUnoEstado = estadoMoneda;
	}

	public bool getMonedaUnoEstado(){
		return this.monedaUnoEstado;
	}
	public void setMonedaDosEstado( bool estadoMoneda){
		this.monedaDosEstado = estadoMoneda;
	}
	
	public bool getMonedaDosEstado(){
		return this.monedaDosEstado;
	}


	public void setControlItemOne(bool itemOne){
		this.controlItemOne = itemOne;
	}

	public bool getControlItemOne(){
		return this.controlItemOne;
	}

	public bool getControlBalaDestruida(){
		return this.controlBalaDestruida;
	}
	public void setControlItemTwo(bool itemtwo){
		this.controlItemTwo = itemtwo;
	}
	public void setControlBalaDestruida(bool m){
		this.controlBalaDestruida = m;
	}

	public void pausa (){
	

			if (paused) {
				paused = false;
				Time.timeScale = 1;
			} else {
				paused = true;
				Time.timeScale = 0;
			}

		}


  public void moverArriba(){
	}
	public void moverAbajo(){
	}

	void Start(){
	

	}
	
	void Update(){

		inputVertical =Input.GetAxis("Vertical") * 10;
		yVelocity = rigidbody2D.velocity.y;
		yVelocity = inputVertical;
		rigidbody2D.velocity = new Vector2(0,yVelocity);
   }

	
	void OnTriggerEnter2D(Collider2D triangulo){

		var nombre = triangulo.gameObject.name;
		if (nombre == "paredInferior" || nombre == "paredSuperior") {

			Destroy (gameObject);
			Application.LoadLevel("Gameover");
		}
	}

}