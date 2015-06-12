using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class NaceItem : MonoBehaviour {

	public float spawnTime = 20;
	public float spawnTime2 = 30;
	public GameObject itemCoinTwo;
	public GameObject itemCoinOne;

	void Start() {
 
		InvokeRepeating("InstanciacionOne", spawnTime, spawnTime+30);
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

		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;


		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);

		return spawnPoint;
	}
	
	Vector3 origenItemCoinOne() {

		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;

		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);

		return spawnPoint;
	}
	
}
