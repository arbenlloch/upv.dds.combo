using UnityEngine;
using System.Collections;

public class ZOR_Command : Command {

	public ZOR_Command(EnemigoCombo2 receiver) :
		base(receiver)
	{
	}
	
	public override void Execute()
	{
		
		combo2Comando.mataCombo ();
		
	}
}
