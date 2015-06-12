using UnityEngine;
using System.Collections;


public class Esc_Command : Command {


	public Esc_Command(PlayerDDS receiver) :
	base(receiver){}

	public override void Execute()
	{		
		//LLAMAR METODOS MOVER Y CAMBIARAPARIENCIA

		playerComando.pausa();

	}

}
