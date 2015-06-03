using UnityEngine;
using System.Collections;
/*
public class Keyboard : MonoBehaviour {

	GameObject jugador;
	PlayerController playerControlador;
	Command Upperc;
	Command Downc;
	Command Escc;
	Invoker invoker;


	// Use this for initialization
	void Start () {

		jugador = GameObject.Find ("triangulo");
		playerControlador = jugador.GetComponent<PlayerController>();
		Command Upperc = new Upper_Command(playerControlador);
		Command Downc = new Down_Command(playerControlador);
		Command Escc = new Esc_Command(playerControlador);

		invoker = new Invoker ();

		invoker.SetCommand (Upperc, Downc, Escc);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown("Down"))
		    invoker.ExecuteDown();

		if (Input.GetKeyDown("Up"))
			invoker.ExecuteUpper();

		if (Input.GetKeyDown("Esc"))
			invoker.ExecuteEsc();
		
	}
}
*/