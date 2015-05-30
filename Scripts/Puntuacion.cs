using UnityEngine;
using System.Collections;
using System;


public class Puntuacion : MonoBehaviour{
	
	public int puntuacion; // <--Refactoring!!!!!!!!!!!!!!!!
	public TextMesh texto;
	private static Puntuacion objetoPuntuacion; //averiguar que significa "_" (Creo que parar diferenciar metodo de variable


	//Patron Singleton
	public static Puntuacion ObjetoPuntuacion(){
		Debug.Log ("SE ESTA CREANDO");
		Debug.Log (objetoPuntuacion);
			if(objetoPuntuacion == null){
				GameObject objPuntuacion = new GameObject ("Objeto Puntuacion");
				objetoPuntuacion = objPuntuacion.AddComponent<Puntuacion>();
			Debug.Log ("SE HA AÑADIDO");
			Debug.Log (objetoPuntuacion);
				//Tell unity not to destroy this object when loading a new scene!
				DontDestroyOnLoad(objetoPuntuacion);
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
		NotificationCenter.DefaultCenter().AddObserver(this, "IncrementarPuntos");

	}
	
	void IncrementarPuntos(Notification notification){ 
		int puntosAIcrementar = (int)notification.data;	
		puntuacion += puntosAIcrementar;
		}

	void ActualizarMarcador(){
		texto.text = puntuacion.ToString();
	}
	void Update (){

//		GetComponent. = 
		ObjetoPuntuacion().ActualizarMarcador ();

		Debug.Log (Puntuacion.objetoPuntuacion.puntuacion);

	}
}