using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class NaceItem : MonoBehaviour {
	
// Variable to know how fast we should create new enemies
	public float spawnTime = 20;
	public float spawnTime2 = 30;
	public GameObject itemCoinTwo;
	public GameObject itemCoinOne;

	void Start() {
 
		InvokeRepeating("InstanciacionOne", spawnTime, spawnTime+10);
		InvokeRepeating("InstanciacionTwo", spawnTime2, spawnTime2+10);
	}
	
	void InstanciacionTwo()
	{
		Instantiate (itemCoinTwo, origenItemCoinTwo(), Quaternion.identity);
	}
	
	void InstanciacionOne()
	{
		Instantiate (itemCoinOne, origenItemCoinOne(), Quaternion.identity);
	}

	Vector3 origenItemCoinTwo() {
		// Variables to store the X position of the spawn object
		// See image below
		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;

		// Randomly pick a point within the spawn object
		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);

		return spawnPoint;
	}
	
	Vector3 origenItemCoinOne() {
		// Variables to store the X position of the spawn object
		// See image below
		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;

		// Randomly pick a point within the spawn object
		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);

		return spawnPoint;
	}
	
}
