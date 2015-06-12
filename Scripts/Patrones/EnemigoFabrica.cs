using System;
using UnityEngine;
namespace AssemblyCSharp
{
	public class EnemigoFabrica : MonoBehaviour
	{

		public EnemigoFabrica ()
		{

		}

		public void construyeEnemigo(Vector3 spawnPoint, double dificultad, GameObject enemigoJuego){

			if (dificultad == 1) {
				Instantiate (enemigoJuego, spawnPoint, Quaternion.identity);
			}
		}
	}
}