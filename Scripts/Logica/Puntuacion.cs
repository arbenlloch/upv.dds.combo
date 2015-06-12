using UnityEngine;
using System.Collections;
using System;


public class Puntuacion : MonoBehaviour,iPuntuacion {
	
	public int puntuacion;
	public TextMesh texto;
	private static Puntuacion objetoPuntuacion=null;
	private static GameObject gameObjetoPuntuacion=null;

	//Patron Singleton
	public static Puntuacion ObjetoPuntuacion(){

			if(objetoPuntuacion == null){
				gameObjetoPuntuacion = new GameObject ("Objeto Puntuacion");
				objetoPuntuacion = gameObjetoPuntuacion.AddComponent<Puntuacion>();
				//Tell unity not to destroy this object when loading a new scene!
				
			}
		return objetoPuntuacion;
	}

	void Awake (){

		if (objetoPuntuacion == null) {
			
			objetoPuntuacion = this;
			DontDestroyOnLoad (gameObject);
		} else {

			if (this != objetoPuntuacion) {
			Destroy (this.gameObject);
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

	public void actualizarMarcador(){
			texto.text = puntuacion.ToString ();
	}



	void Update (){

		ObjetoPuntuacion().actualizarMarcador ();
		if (Application.loadedLevelName == "Gameover") {
			texto.transform.position = new Vector3(220,158,0);
			texto.fontSize = 250;
		}

	}
}