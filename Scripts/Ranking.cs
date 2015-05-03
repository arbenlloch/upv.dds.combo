using UnityEngine;
using System.Collections;
using System;

public class Ranking : MonoBehaviour{

	private string[] nomRanking = new string[3] { "AAA", "AAB", "AAC" } ; //Array de almacenamiento de los 3 primeros nombres con mejor puntuacion
	private int[] punRanking = new int[3] {300, 200, 100} ;    //Array de almacenamiento de las 3 mejores puntuaciones




	public int compruebaPuntuacion (int puntuacion){
		if (puntuacion > punRanking [1]) //Primer puesto de puntuacion
			return 1;
		else if (puntuacion > punRanking [2]) //Segundo puesto de puntuacion
			return 2;
		else if (puntuacion > punRanking [3]) //Tercer puesto de puntuacion
			return 3;
		else
			return -1; //Record no conseguido
	}


	//Se puede hacer con bucle, refactoring.

	public void configuraRanking (string nombre, int posicion, int puntuacion){
	
	     if (posicion == 1) { //Se ha conseguido el primer Record, modificamos todo el ranking.
			nomRanking [3] = nomRanking [2];
			nomRanking [2] = nomRanking [1];
			nomRanking [1] = nombre;

			punRanking [3] = punRanking [2];
			punRanking [2] = punRanking [1];
			punRanking [1] = puntuacion;

		} else if (posicion == 2) { //Se ha conseguido el segundo Record, modificamos 2ndo y 3er puesto
			nomRanking [3] = nomRanking [2];
			nomRanking [2] = nombre;

			punRanking [3] = punRanking [2];
			punRanking [2] = puntuacion;

		} else if (posicion == 3) { //Se ha conseguido el 3er record, modificamos 3er puesto.
			nomRanking [3] = nombre;
			punRanking [3] = puntuacion;
		}

    }
}
