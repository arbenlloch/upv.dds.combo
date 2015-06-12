using UnityEngine;
using System.Collections;

public class Space_Command : Command {


	public Space_Command(PlayerDDS receiver) : base(receiver){}

	public override void Execute()
	{

		playerComando.funcionalidad();

	}
}