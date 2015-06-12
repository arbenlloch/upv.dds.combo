using UnityEngine;
using System.Collections;


public class Down_Command : Command {
	
		// Constructor
	public Down_Command(PlayerDDS receiver) : base(receiver){}
		
		public override void Execute()
		{
		//LLAMAR METODOS MOVER Y CAMBIARAPARIENCIA
		//playerComando.moverAbajo ();
		}
	}

