using UnityEngine;
using System.Collections;

public class EmpezarPortada : MonoBehaviour {

	void OnMouseDown(){
		Application.LoadLevel ("Juego");
		DestroyObject (Puntuacion.ObjetoPuntuacion ());
		GameObject textPuntuacion = GameObject.Find ("TextoPuntuacion");
		GameObject puntua = GameObject.Find ("Puntua");
		DestroyObject (textPuntuacion);
		DestroyObject (puntua);
	}
}