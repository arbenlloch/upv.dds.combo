using UnityEngine;
using System.Collections;
using System;


public class PuntuacionGameOver : MonoBehaviour {
	
	public int puntuacion; // <--Refactoring!!!!!!!!!!!!!!!!
	public TextMesh texto;
	private static PuntuacionGameOver objetoPuntuacionGameOver; //averiguar que significa "_" (Creo que parar diferenciar metodo de variable
	
	
	//Patron Singleton
	public static PuntuacionGameOver ObjetoPuntuacionGameOver(){
	
		if(objetoPuntuacionGameOver == null){
			GameObject objPuntuacionGameOver = new GameObject ("Objeto Puntuacion Game Over");
			objetoPuntuacionGameOver = objPuntuacionGameOver.AddComponent<PuntuacionGameOver>();
		
			//Tell unity not to destroy this object when loading a new scene!
			DontDestroyOnLoad(objetoPuntuacionGameOver);
		}
		
		return objetoPuntuacionGameOver;
	}

	void Awake (){
		objetoPuntuacionGameOver = ObjetoPuntuacionGameOver ();
		objetoPuntuacionGameOver.puntuacion = Puntuacion.ObjetoPuntuacion().puntuacion;
	}
	void Start (){
		//objetoPuntuacionGameOver.puntuacion = Puntuacion;
		
	}
}