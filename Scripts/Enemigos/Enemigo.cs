using UnityEngine;
using System.Collections;
using System;

public class Enemigo : MonoBehaviour
{
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