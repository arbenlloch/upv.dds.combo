using UnityEngine;
using System;
using System.Collections;


public abstract class Command : MonoBehaviour
{ 

	public PlayerDDS playerComando;
	public EnemigoCombo1 combo1Comando;
	public EnemigoCombo2 combo2Comando;
	// Constructor general para comando.
	//Se captura el receptor de el comando.
	public Command(PlayerDDS receiver)
	{
			this.playerComando = receiver;
		}

		public Command ( EnemigoCombo1 receiver2 )
		{
		combo1Comando = receiver2;
	
		}
		public Command ( EnemigoCombo2 receiver3 )
		{
		combo2Comando = receiver3;
		
		}
		
		//Ejecucion de el comando
		public abstract void Execute();
}
