using UnityEngine;
using System.Collections;

public class ItemCoinOne : MonoBehaviour
{	
	public ItemCoinOne(){
		this.destruido = false;
	}

	public int speed = -5;
	private bool destruido;
	private GameObject jugador;
	private PlayerController playerDecorandose;

	// Use this for initialization
	void Start ()
	{
//		NotificationCenter.DefaultCenter().AddObserver(this, "CambiarEstado");
//		/destruido = false;

		rigidbody2D.velocity = new Vector2 (speed, 0);
		Destroy(gameObject, 7);
	}
	

//	void CambiarEstado(Notification notification){ 
//		bool varCambioEstado = (bool)notification.data;	
//		destruido = true;//MODIFICAR
//		Debug.Log (destruido);
//	}

	public bool getDestruido(){
		return this.destruido;
	}

	public void setDestruido(bool d){
		this.destruido = d;
	}

	void  OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;
		
		if (name == "triangulo") {

			destruido = true;
			jugador = GameObject.Find ("triangulo");
			playerDecorandose = jugador.GetComponent<PlayerController>();
			playerDecorandose.setMonedaUnoEstado(destruido);
//			playerDecorandose.setTiempoCoinOne(playerDecorandose.getTiempoCoinOne()-Time.realtimeSinceStartup);

			Destroy (gameObject);
			
			//Lanzamos Gameover
		}

		if (name == "bullet(Clone)") {
			//Desturye Bala o el jugador
			Destroy(obj.gameObject);
		}
	}

//	private void aplicaCoinOne(){
//		//Component g = GameObject.Find ("triangulo").GetComponent("PlayerController");
//		 jugador = GameObject.FindGameObjectWithTag("Player");
//		Debug.Log ("Dentro de aplicaCoInOne y estado de destruido es: "+destruido);
//		//Sprite g = Sprite.FindObjectOfType();
//		//Get
//
//
//		PlayerController playerSinDecorado = jugador.GetComponent<PlayerController>();
//		playerSinDecorado.setMonedaUnoEstado (destruido);
//		PlayerDDS playerDecorado = playerSinDecorado.GetComponent<PlayerController>();
//		//PlayerDDS y = (PlayerController) jugador.GetComponent("PlayerController.cs");
//		
//		playerDecorado = UsoItems.aplicarCoinOne (playerDecorado);
//		//Debug.Log ((PlayerControlloer)p.getMonedaUnoEstado ());
//		playerDecorado.funcionalidad();
//		
//		/*  // To access public variables and functions 
//    // in another script attached to the same game object.
//    var script : ScriptName;
//    script = GetComponent("ScriptName");
//    script.DoSomething ();*/
//		
//		Debug.Log ("Saliendo de aplicaCoInOne");
//	    //g = new DecoradorCoinOne(y);
//		//g.GetComponent("PlayerController")
//	}


	/*
	 * public class Puntuacion : MonoBehaviour{
		public int puntuacion;
	public TextMesh texto;
		

	void Start (){
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
		puntuacion = 0;
	}
	
	void IncrementarPuntos(Notification notification){ 
		int puntosAIcrementar = (int)notification.data;	
		puntuacion += puntosAIcrementar;
		Debug.Log (puntuacion);
		}

	void ActualizarMarcador(){
		texto.text = puntuacion.ToString();
	}
	void Update (){
		ActualizarMarcador ();
	}
}


	 */
}