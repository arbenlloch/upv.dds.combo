using UnityEngine;
using System.Collections;

public class NaceEnemigo : MonoBehaviour {

	// Variable to store the enemy prefab
public GameObject enemy;
public GameObject combo1;

// Variable to know how fast we should create new enemies
public float spawnTime = 2;
public float spawnTime2 = 5;

void Start() {  
    // Call the 'crearEnemigo' function every 'spawnTime' seconds
    InvokeRepeating("crearEnemigo", spawnTime, spawnTime);
	InvokeRepeating("crearEnemigo2", spawnTime, spawnTime2);
}

// New function to spawn an enemy
	void crearEnemigo() {  
		// Variables to store the X position of the spawn object
		// See image below
		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;

		// Randomly pick a point within the spawn object
		var spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);

		// Create an enemy at the 'spawnPoint' position
		Instantiate (enemy, spawnPoint, Quaternion.identity);
	}

	void crearEnemigo2() {

		var x1 = transform.position.y - renderer.bounds.size.y/2;
		var x2 = transform.position.y + renderer.bounds.size.y/2;

		var spawnPoint2 = new Vector3(transform.position.x,Random.Range(x1, x2),-0.5f);
		
		// Create an enemy at the 'spawnPoint' position
		Instantiate(combo1, spawnPoint2, Quaternion.identity);

	}
}
