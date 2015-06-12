using UnityEngine;
using System.Collections;
//using System;

public class PlayerDDS : PlayerController{

	public PlayerDDS(){
	}

	//Funcionalidad concreta
	public override void funcionalidad()
	{
		Debug.Log (transform.position.x + 1);
		Vector3 posicionBala= new Vector3(transform.position.x + 1, transform.position.y,transform.position.z);
		Instantiate(bala,posicionBala, Quaternion.identity);
	}
}