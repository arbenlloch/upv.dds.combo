using UnityEngine;
using System.Collections;

public class EnemigoBala : EnemigoStandard
{
	public EnemigoBala(){
		
	}

	public int speed = -7;

	void Start(){
		rigidbody2D.velocity = new Vector2(speed,0);
		Destroy(gameObject, 7);
	}		
}

