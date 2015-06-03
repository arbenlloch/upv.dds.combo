using UnityEngine;
using System.Collections;

//Constructor de extends los dos puntos. El MonoBehaviour sera el padre que tendra todo lo necesario para que 
//el objeto tenga comportamiento
public class PlayerController : MonoBehaviour,PlayerDDS
{
	public float velocity;
	public GameObject bala;
	public GameObject balaDoble;
	public Puntuacion puntuacion;
	private float inputVertical;
	private float yVelocity;
	private bool monedaUnoEstado;
	private bool controlBalaDestruida;
	private bool controlItemOne;
	private double tiempoCoinOne;

	//VERSION 2D
	GameObject coinOne;
	ItemCoinOne m;




	public PlayerController(){
		this.tiempoCoinOne = 0.0;
	}

	public void ReestablecerValores (){
		this.monedaUnoEstado= false;
		this.controlBalaDestruida = false;
		this.controlItemOne = false;
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

	public void setcontrolBalaDestruida(bool m){
		this.controlBalaDestruida = m;
	}

	public void setControlItemOne(bool itemOne){
		this.controlItemOne = itemOne;
	}

	public bool getControlBalaDestruida(){
		return this.controlBalaDestruida;
	}
	
	void Update(){

		inputVertical =Input.GetAxis("Vertical") * 10;
		yVelocity = rigidbody2D.velocity.y;
		yVelocity = inputVertical;
		rigidbody2D.velocity = new Vector2(0,yVelocity);
//		if (coinOne!=null) {
//			coinOne = GameObject.Find ("itemCoinOne(Clone)");
//			m = coinOne.GetComponent<ItemCoinOne>();
//			setMonedaUnoEstado (m.getDestruido());
//		}



		funcionalidad();
   }

	
	void OnTriggerEnter2D(Collider2D triangulo){

		var nombre = triangulo.gameObject.name;
		if (nombre == "paredInferior" || nombre == "paredSuperior") {

			Destroy (gameObject);
			Application.LoadLevel("Gameover");

		}
		
	}

	public void funcionalidad()
	{
		if (Input.GetKeyDown("space")) {
        // Create a new bullet at “transform.position”
        // Which is the current position of the ship
		Vector3 posicionBala= new Vector3(transform.position.x + 1, transform.position.y,transform.position.z);
        Instantiate(bala,posicionBala, Quaternion.identity);
		}
	}


}