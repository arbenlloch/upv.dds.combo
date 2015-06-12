using UnityEngine;
using System.Collections;

public class Invoker : MonoBehaviour {

		private Command Upper_command;
		private Command Down_command;
		private Command Esc_command;
		private Command Space_command;
		private Command QMG_command;

		

	public Invoker(){
	}

	public void SetCommand(Command Up_C,Command Down_C, Command Esc_C, Command Space_C)
		{
			Upper_command = Up_C;
			Down_command = Down_C;
			Esc_command = Esc_C;
			Space_command = Space_C;

			
		}
	public void SetCommand(Command QMG_C )
	{

		QMG_command = QMG_C;
		
	}

	
	public void ExecuteUpper()
	{
			Upper_command.Execute();
	}
		public void ExecuteDown()
	{
		Down_command.Execute ();
	}
		public void ExecuteEsc()

	{
		Esc_command.Execute ();
		
	}
		public void ExecuteSpace()
		{

		Space_command.Execute();
	}
		public void ExecuteQMG()
		{
		QMG_command.Execute ();
		
	}


}
