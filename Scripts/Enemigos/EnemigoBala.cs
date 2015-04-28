using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class EnemigoFabrica : MonoBehaviour
	{
		
		//GameObject enemigoRoca = new EnemigoRoca();
		//GameObject enemigoCombo = new EnemigoCombo();
		
		
		public EnemigoFabrica ()
		{
			
		}
		
		public void construyeEnemigo(Vector3 spawnPoint, double dificultad, GameObject enemigoJuego){
			
			if (dificultad == 1) {
				Debug.Log("Difultad 1");
				Instantiate (enemigoJuego, spawnPoint, Quaternion.identity);
			}
			/**else
				if (dificultad == 2) {

					Instantiate (new EnemigoRoca(), spawnPoint, Quaternion.identity);
					Instantiate (new EnemigoCombo(), spawnPoint, Quaternion.identity);
					Console.Write("Difultad 2");	
			}else

				Instantiate (new EnemigoRoca(), spawnPoint, Quaternion.identity);
				Instantiate (new EnemigoCombo(), spawnPoint, Quaternion.identity);
				Console.Write("Difultad 3");
			**/
		}
	}
}