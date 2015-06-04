
using UnityEngine;
using System.Collections;

public class Empezar : MonoBehaviour {

	private GameObject jugador;
	private PlayerController playerDecorandose;
	PlayerDDS playerDecorado;
	private double tiempo = 9.0;
	private double diferencia;
	private double tiempoAux1SinceLevelLoad;
	private double tiempoAux2;
	private double tiempoAux3;

	// Use this for initialization
	void Start () {
		if (Application.loadedLevelName == "Juego") {

			//DontDestroyOnLoad (gameObject);
			jugador = GameObject.Find ("triangulo");
			playerDecorandose = jugador.GetComponent<PlayerController> ();
			//playerDecorado = playerDecorandose.GetComponent<PlayerController>();
			tiempoAux1SinceLevelLoad = Time.timeSinceLevelLoad;
			playerDecorado = null;
		}
	}

	// Update is called once per frame
	void Update () {
		if (Application.loadedLevelName == "Juego") {

			//Funcionalidad decorado1
			//if (playerDecorandose.getMonedaUnoEstado () && (tiempoAux1SinceLevelLoad + 20.0) >= Time.timeSinceLevelLoad)
			if (playerDecorandose.getMonedaUnoEstado ()) {

				playerDecorado = UsoItems.aplicarCoinOne (playerDecorandose);
				playerDecorado.funcionalidad ();
				StartCoroutine ("corutinaMoneda1", 10.0);

				//if ((tiempoAux1SinceLevelLoad + 20.0) < Time.timeSinceLevelLoad) {
				//	Debug.Log ("Dentro del reestablecimiento");
				//	jugador = GameObject.Find ("triangulo");
				//	playerDecorandose = jugador.GetComponent<PlayerController> ();

				//	tiempoAux1SinceLevelLoad = Time.timeSinceLevelLoad;
			}

			//Funcionalidad decorado2
			//if (playerDecorandose.getMonedaDosEstado () && (tiempoAux1SinceLevelLoad + 20.0) >= Time.timeSinceLevelLoad)
			if (playerDecorandose.getMonedaDosEstado ()) {
				//Debug.Log ("Paso 1 item2 añadido realizado");
				playerDecorado = UsoItems.aplicarCoinTwo (playerDecorandose);
				playerDecorado.funcionalidad ();
				StartCoroutine ("corutinaMoneda2", 10.0);
				playerDecorandose.setMonedaDosEstado (false);
				//Debug.Log ("Fuera del reestablecimiento este es auxTime " + tiempoAux1SinceLevelLoad + 20.0 + " y este el realTime " + Time.timeSinceLevelLoad);
				//if ((tiempoAux1SinceLevelLoad + 20.0) < Time.timeSinceLevelLoad) {
				//	Debug.Log ("Dentro del reestablecimiento2");
				//	jugador = GameObject.Find ("triangulo");
				//	playerDecorandose = jugador.GetComponent<PlayerController> ();
				//	playerDecorandose.bala.transform.localScale = new Vector3 (2,2,2);
				//	tiempoAux1SinceLevelLoad = Time.timeSinceLevelLoad;
			}
		}
	}
			//playerDecorandose.ReestablecerValores ();
			//playerDecorandose.funcionalidad();

	IEnumerator corutinaMoneda1 (float t){
		
		while (true) {
			Debug.Log ("MonedaUnoEstado es: "+playerDecorandose.getMonedaUnoEstado()+"Control Bala Destruida es: "+playerDecorandose.getControlBalaDestruida()+"Control Item One es: "+playerDecorandose.getControlItemOne());

			yield return new WaitForSeconds (t);
			playerDecorandose.setMonedaUnoEstado (false);
			playerDecorandose.setControlBalaDestruida(false);
			playerDecorandose.setControlItemOne(false);
			Debug.Log ("MonedaUnoEstado es: "+playerDecorandose.getMonedaUnoEstado()+" Control Bala Destruida es: "+playerDecorandose.getControlBalaDestruida()+" Control Item One es: "+playerDecorandose.getControlItemOne());
			//playerDecorandose.bala.transform.localScale = new Vector3 (2, 2, 2);
			//playerDecorandose.ReestablecerValores();
		}
	}
	IEnumerator corutinaMoneda2 (float t){
	
		while (true) {
			yield return new WaitForSeconds(t);
			playerDecorandose.bala.transform.localScale = new Vector3(2,2,2);
			playerDecorandose.setControlItemTwo(false);
			//playerDecorandose.ReestablecerValores();
		}
	}

}