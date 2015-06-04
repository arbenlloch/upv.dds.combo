using UnityEngine;
using System.Collections;

public class QMG_Command : Command {

	public QMG_Command(EnemigoCombo1 receiver) :
		base(receiver)
	{
	}

	public override void Execute()
	{

		combo1Comando.mataCombo ();

	}
}
