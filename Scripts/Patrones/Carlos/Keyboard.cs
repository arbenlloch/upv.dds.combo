using UnityEngine;
using System.Collections;

public class Keyboard : MonoBehaviour {

	GameObject jugador;
	GameObject combo1;
	GameObject combo2;
	PlayerController playerControlador;
	EnemigoCombo1 enemigoCombo1;
	EnemigoCombo2 enemigoCombo2;
	Command Upperc;
	Command Downc;
	Command Escc;
	Command Spacec;
	Command QMGc;
	Command ZORc;
	Invoker invoker;

	public bool comp = false;
	public bool comp2 = false;
	public bool comp3 = false;
	public bool comp4 = false;


	// Use this for initialization
	void Start () {

		jugador = GameObject.Find ("triangulo");
		playerControlador = jugador.GetComponent<PlayerController>();
		Upperc = new Upper_Command(playerControlador);
		Downc = new Down_Command(playerControlador);
		Escc = new Esc_Command(playerControlador);
		Spacec = new Space_Command(playerControlador);


		invoker = new Invoker ();

		invoker.SetCommand (Upperc, Downc, Escc, Spacec);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.DownArrow))
		    invoker.ExecuteDown();

		if (Input.GetKeyDown(KeyCode.UpArrow))
			invoker.ExecuteUpper();

		if (Input.GetKeyDown (KeyCode.Escape)) 
			invoker.ExecuteEsc ();

		if (Input.GetKeyDown (KeyCode.Space))
			invoker.ExecuteSpace ();

		//Secuencia Combos

		if (GameObject.Find ("combo1(Clone)") != null) {


			combo1 = GameObject.Find ("combo1(Clone)");
			enemigoCombo1 = combo1.GetComponent<EnemigoCombo1> ();
			QMGc = new QMG_Command (enemigoCombo1);
			invoker.SetCommand (QMGc);
		}

		
			if (Input.GetKeyDown ("q")) 
				comp = true;
		
			if (comp && Input.GetKeyDown ("m"))
				comp2 = true;
		
			if (comp && comp2 && Input.GetKeyDown ("g")) {
				invoker.ExecuteQMG ();
			}


		if (GameObject.Find ("combo2(Clone)") != null) {
			
			
			combo2 = GameObject.Find ("combo2(Clone)");
			enemigoCombo2 = combo2.GetComponent<EnemigoCombo2> ();
			ZORc = new ZOR_Command (enemigoCombo2);
			invoker.SetCommand (ZORc);
		}

		if (Input.GetKeyDown ("z")) 
			comp = true;
		
		if (comp && Input.GetKeyDown ("o"))
			comp2 = true;
		
		if (comp && comp2 && Input.GetKeyDown ("r")) {
			invoker.ExecuteQMG ();
		}

		}
	}


