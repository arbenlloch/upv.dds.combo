using UnityEngine;
using System.Collections;
using System;

public class Enemigo : MonoBehaviour {

	// Public variable that contains the speed of the enemy
	private int numeroEnemigos=0;

	public Enemigo(){
		Debug.Log("Soy el enemigo MAESTRO numero " + getNumEnemigo());
		this.numeroEnemigos++;
	}
	
	public int getNumEnemigo()
	{
		return this.numeroEnemigos;
	}
	
	public void setNumEnemigos(int num){
		this.numeroEnemigos = num;
	}
}