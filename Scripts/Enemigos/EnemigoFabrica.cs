using UnityEngine;
using System.Collections;
using System;

public class EnemigoRoca : Enemigo{

	// Public variable that contains the speed of the enemy
	public int speed = -5;
	
	// Function called when the enemy is created
	void Start(){
		// Add a vertical speed to the enemy
		rigidbody2D.velocity = new Vector2(speed,0);
		
		// Make the enemy rotate on itself
		//rigidbody2D.angularVelocity = UnityEngine.Random.Range(-200, 200);
		
		// Destroy the enemy in 3 seconds,
		// when it is no longer visible on the screen
		Destroy(gameObject, 7);
		
		//Function called when the enemy collides with another object
	}

	void OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;
			
			// If it collided with a bullet
			if (name == "bullet(Clone)") {
				// Destroy itself (the enemy)
			//Console.WriteLine(name.ToString());
				Destroy(gameObject);
				
				//And destroy the bullet
			Destroy(obj.gameObject);
			}
			
			// If it collided with the spaceship
			if (name == "triangulo") {
				// Destroy itself (the enemy) to keep things simple
				Destroy(gameObject);
			//Console.WriteLine(name.ToString());
			//And destroy the spaceship
			Destroy(obj.gameObject);
		}
	 }
}
