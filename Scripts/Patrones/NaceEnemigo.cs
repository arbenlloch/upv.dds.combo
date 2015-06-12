using UnityEngine;
using System.Collections;
using AssemblyCSharp;

public class NaceEnemigo : MonoBehaviour {

	public float spawnTime = 2;
	public float spawnTime2 = 1;
	private int	dificultad = 1;
	private double pasadas;
	public GameObject enemigoBala;
	public GameObject enemigoRoca;
	public GameObject enemigoCombo1;
	public GameObject enemigoCombo2;
	public EnemigoFabrica fabricaStandar;
	public EnemigoFabrica fabricaCombos;

	void Start() {
 
		fabricaStandar = new EnemigoFabrica();
		fabricaCombos = new EnemigoFabrica();
		
	    InvokeRepeating("construir", spawnTime, spawnTime2);
	}

	void construir(){
		int aleatoriedad = Random.Range(1,5);
		Debug.Log (aleatoriedad);
		switch(aleatoriedad){
		case 1:
			fabricaStandar.construyeEnemigo(origenEnemigoStandard(),dificultad,enemigoRoca);
			break;
		case 2:
			fabricaStandar.construyeEnemigo(origenEnemigoStandard(),dificultad,enemigoBala);
			break;
		case 3:
			fabricaCombos.construyeEnemigo (origenEnemigoCombo (), dificultad, enemigoCombo2);
			break;
		case 4:
			fabricaCombos.construyeEnemigo (origenEnemigoCombo (), dificultad, enemigoCombo1);
			break;
		default:
			fabricaCombos.construyeEnemigo (origenEnemigoCombo (), dificultad, enemigoCombo1);
			break;
		}
	}

	Vector3 origenEnemigoStandard() {

		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;

		// Eleccion aleatoria entre un rango comprendido dentro del objeto en pantalla, spawn.
		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);

		return spawnPoint;
	}

	Vector3 origenEnemigoCombo() {
		var x1 = transform.position.y - renderer.bounds.size.y / 2;
		var x2 = transform.position.y + renderer.bounds.size.y / 2;

		Vector3 spawnPoint = new Vector3 (transform.position.x, Random.Range (x1, x2), -0.5f);
		
		return spawnPoint;
	}
}
