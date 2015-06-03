using UnityEngine;
using System.Collections;

public class Empezar : MonoBehaviour {

	private GameObject jugador;
	private PlayerController playerDecorandose;
	PlayerDDS playerDecorado;
	private double tiempo = 9.0;
	private double diferencia;
	private double auxTime;

	// Use this for initialization
	void Start () {
		if (Application.loadedLevelName == "Juego") {

			//DontDestroyOnLoad (gameObject);
			jugador = GameObject.Find ("triangulo");
			playerDecorandose = jugador.GetComponent<PlayerController> ();
			//playerDecorado = playerDecorandose.GetComponent<PlayerController>();
			auxTime = Time.realtimeSinceStartup;
			playerDecorado = null;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "Juego") {
			Debug.Log ("Antes del decorado 1 "+playerDecorandose.getMonedaUnoEstado());
			if (playerDecorandose.getMonedaUnoEstado () && (auxTime + 20.0) >= Time.realtimeSinceStartup) {
				Debug.Log ("Paso 1 item añadido realizado");
//			if(playerDecorado==null){
				playerDecorado = UsoItems.aplicarCoinOne (playerDecorandose);
//			}
				playerDecorado.funcionalidad ();
				Debug.Log ("Fuera del reestablecimiento este es auxTime " + auxTime + 20.0 + " y este el realTime " + Time.realtimeSinceStartup);
				if ((auxTime + 20.0) < Time.realtimeSinceStartup) {
					Debug.Log ("Dentro del reestablecimiento");
					jugador = GameObject.Find ("triangulo");
					playerDecorandose = jugador.GetComponent<PlayerController> ();

					auxTime = Time.realtimeSinceStartup;
				}
			}

			//Funcionalidad decorado2
			Debug.Log("Estado de la moneda 2"+playerDecorandose.getMonedaDosEstado());
			if (playerDecorandose.getMonedaDosEstado () && (auxTime + 20.0) >= Time.realtimeSinceStartup) {
				Debug.Log ("Paso 1 item2 añadido realizado");
				playerDecorado = UsoItems.aplicarCoinTwo (playerDecorandose);

				playerDecorado.funcionalidad ();
				Debug.Log ("Fuera del reestablecimiento este es auxTime " + auxTime + 20.0 + " y este el realTime " + Time.realtimeSinceStartup);
				if ((auxTime + 20.0) < Time.realtimeSinceStartup) {
					Debug.Log ("Dentro del reestablecimiento2");
					jugador = GameObject.Find ("triangulo");
					playerDecorandose = jugador.GetComponent<PlayerController> ();
					playerDecorandose.bala.transform.localScale = new Vector3 (2,2,2);
					auxTime = Time.realtimeSinceStartup;
				}

			}
			//playerDecorandose.ReestablecerValores ();
			//playerDecorandose.funcionalidad();
			Debug.Log ("Fuera del if");
		}
	}
}