﻿
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
			if (playerDecorandose.getMonedaUnoEstado () && (auxTime + 20.0) >= Time.realtimeSinceStartup) {
//			if(playerDecorado==null){
				playerDecorado = UsoItems.aplicarCoinOne (playerDecorandose);
//			}
				playerDecorado.funcionalidad ();
				if ((auxTime + 20.0) < Time.realtimeSinceStartup) {
					Debug.Log ("Dentro del reestablecimiento");
					jugador = GameObject.Find ("triangulo");
					playerDecorandose = jugador.GetComponent<PlayerController> ();
					playerDecorandose.ReestablecerValores ();
					auxTime = Time.realtimeSinceStartup;
				}
			}
			//playerDecorandose.funcionalidad();
		}
	}
}