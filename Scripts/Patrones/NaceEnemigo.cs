using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class NaceEnemigo : MonoBehaviour {
	
// Variable to know how fast we should create new enemies
	public float spawnTime = 2;
	public float spawnTime2 = 5;
	private int	dificultad = 1;
	private double pasadas;
	public GameObject enemigoBala;
	public GameObject enemigoRoca;
	public GameObject enemigoCombo1;
	public EnemigoFabrica fabricaStandar;
	public EnemigoFabrica fabricaCombos;

	void Start() {
 
		fabricaStandar = new EnemigoFabrica();
		fabricaCombos = new EnemigoFabrica();
		
		if (dificultad == 1) InvokeRepeating("construir", spawnTime, spawnTime2);
		if (dificultad == 2) InvokeRepeating("construir", spawnTime, spawnTime);
		if (dificultad == 3) InvokeRepeating("construir", spawnTime, spawnTime);
		if (dificultad == 4) InvokeRepeating("construir", spawnTime, spawnTime);
		if (dificultad == 5) InvokeRepeating("construir", spawnTime, spawnTime);
	}

	void construir(){
		int aleatoriedad = Random.Range(1,3);
		switch(aleatoriedad){
		case 1:
			fabricaStandar.construyeEnemigo(origenEnemigoStandard(),dificultad,enemigoRoca);
			break;
		case 2:
			fabricaStandar.construyeEnemigo(origenEnemigoStandard(),dificultad,enemigoBala);
			break;
		}
		fabricaCombos.construyeEnemigo(origenEnemigoCombo(),dificultad, enemigoCombo1);
	}

	Vector3 origenEnemigoStandard() {
		// Variables to store the X position of the spawn object
		// See image below
		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;

		// Randomly pick a point within the spawn object
		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);

		return spawnPoint;
	}

	Vector3 origenEnemigoCombo() {
		// Variables to store the X position of the spawn object
		// See image below
		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;
		
		// Randomly pick a point within the spawn object
		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);
		
		return spawnPoint;
	}
}
