using UnityEngine;
using System.Collections;

public class Bala : MonoBehaviour {

	// Public variable 
	//public var speed : int=6;

	public int speed = 6;
    float yVelocity;
	
	// Gets called once when the bullet is created
	void Start () {  
		// Set the Y velocity to make the bullet move upward
		//yVelocity = rigidbody2D.velocity.y;
		rigidbody2D.velocity = new Vector2(speed,0);
	}

	// Gets called when the object goes out of the screen
	void OnBecameInvisible() {  
		// Destroy the bullet 
		Destroy(gameObject);
	}
}