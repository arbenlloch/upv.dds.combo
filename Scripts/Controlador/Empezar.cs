using UnityEngine;
using System.Collections;
using System;

public class Empezar : MonoBehaviour {

	private GameObject jugador;
	private PlayerController playerDecorandoseControler;
	private PlayerController playerControl;
	PlayerDDS playerDecorado;
	private double tiempo = 9.0;
	private double diferencia;
	private double tiempoAux1SinceLevelLoad;
	private double tiempoAux2;
	private double tiempoAux3;
	private DecoradorCoinTwo decoDos;
	
	void Start () {
		if (Application.loadedLevelName == "Juego") {

			jugador = GameObject.Find ("triangulo");
			playerControl = jugador.GetComponent<PlayerController> ();
			decoDos = new DecoradorCoinTwo(playerControl);
			Debug.Log(playerControl.getMonedaDosEstado());
			tiempoAux1SinceLevelLoad = Time.timeSinceLevelLoad;
			playerDecorado = null;
			playerControl.bala.transform.localScale = new Vector3(2,2,2);
		}
	}

	// Este metodo se llamara por cada frame del juego
	void Update(){
		Debug.Log("Dentro de update" + playerControl.getMonedaDosEstado());
		if (Application.loadedLevelName == "Juego" ) {

			//Funcionalidad decorado1
			if (playerControl.getMonedaUnoEstado()) {
				playerDecorandoseControler = UsoItems.aplicarCoinOne(playerControl);
				playerDecorandoseControler.funcionalidad();
				if(playerControl.getControlItemOne()==false){
					//Llamada a corutina donde se tratara el tiempo que el decorado 1 durara.
					StartCoroutine ("corutinaMoneda1", 10.0);
				}
			}
			//Funcionalidad decorado2
			if (playerControl.getMonedaDosEstado ()) {
				playerDecorandoseControler = UsoItems.aplicarCoinTwo(playerControl);
				playerDecorandoseControler.funcionalidad();
				StartCoroutine ("corutinaMoneda2", 10.0);
				playerControl.setMonedaDosEstado (false);
			}
		}
	}

	IEnumerator corutinaMoneda1 (float t){
		playerControl.setControlItemOne(true);
		yield return new WaitForSeconds (t);
		playerControl.ReestablecerValores ();
	}

	IEnumerator corutinaMoneda2 (float t){
			yield return new WaitForSeconds(t);
		playerControl.bala.transform.localScale = new Vector3(2,2,2);
		playerControl.setControlItemTwo(false);
	}
}