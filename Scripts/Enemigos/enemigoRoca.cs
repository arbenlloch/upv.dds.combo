using UnityEngine;
using System.Collections;
using System;

public class EnemigoRoca : EnemigoStandard {

	public int speed = -5;

	public EnemigoRoca(){
		setNumEnemigos (getNumEnemigo()+1);
	}

	void Start(){

		rigidbody2D.velocity = new Vector2(speed,0);
		rigidbody2D.angularVelocity = UnityEngine.Random.Range(-200, 200);
	}
}