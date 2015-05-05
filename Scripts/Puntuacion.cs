using UnityEngine;
using System.Collections;

public class Puntuacion : MonoBehaviour{
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
