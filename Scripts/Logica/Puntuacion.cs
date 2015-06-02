using UnityEngine;
using System.Collections;
using System;


public class Puntuacion : MonoBehaviour{
	
	public int puntuacion; // <--Refactoring!!!!!!!!!!!!!!!!
	public TextMesh texto;
	private static Puntuacion objetoPuntuacion=null; //averiguar que significa "_" (Creo que parar diferenciar metodo de variable
	private static GameObject gameObjetoPuntuacion=null;

	//Patron Singleton
	public static Puntuacion ObjetoPuntuacion(){
		Debug.Log ("SE ESTA CREANDO");
		Debug.Log (objetoPuntuacion);
			if(objetoPuntuacion == null){
				gameObjetoPuntuacion = new GameObject ("Objeto Puntuacion");
				objetoPuntuacion = gameObjetoPuntuacion.AddComponent<Puntuacion>();
				Debug.Log ("SE HA AÑADIDO");
				Debug.Log (objetoPuntuacion);
				//Tell unity not to destroy this object when loading a new scene!
				
			}
		return objetoPuntuacion;
	}

	void Awake (){
		Debug.Log (puntuacion);
		//Si soy la primera instancia de Puntuacion aplico singleton
		if (objetoPuntuacion == null) {
			
			objetoPuntuacion = this;
			Debug.Log ("Te jodes , no me destruyo mas");
			DontDestroyOnLoad (gameObject);
			Debug.Log ("soy el primero");
		} else {//Si Singleton esta aplicado y existe uan referencia a puntuacion en la escena destruyelo

			if (this != objetoPuntuacion) {
			Debug.Log (puntuacion);
			Destroy (this.gameObject);
			Debug.Log ("Ya existe , me autodestruyo");
			}
		}
	}	
		
		
	void Start (){
		DontDestroyOnLoad(objetoPuntuacion);
		DontDestroyOnLoad(texto);
		Puntuacion.ObjetoPuntuacion ();
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");
	}
	
	void IncrementarPuntos(Notification notification){ 
		int puntosAIcrementar = (int)notification.data;	
		puntuacion += puntosAIcrementar;
		}

	void ActualizarMarcador(){
		//if (Application.loadedLevelName == "Juego") {
			texto.text = puntuacion.ToString ();
		//}
	}
	void Update (){

		ObjetoPuntuacion().ActualizarMarcador ();
		if (Application.loadedLevelName == "Gameover") {
			texto.transform.position = new Vector3(223,180,0);
			texto.fontSize = 250;
			//jugador = GameObject.Find ("triangulo");
			//playerDecorandose = jugador.GetComponent<PlayerController> ();
		}
		Debug.Log (Puntuacion.objetoPuntuacion.puntuacion);

	}
}