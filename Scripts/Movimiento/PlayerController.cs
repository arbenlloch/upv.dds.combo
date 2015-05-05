using UnityEngine;
using System.Collections;

//Constructor de extends los dos puntos. El MonoBehaviour sera el padre que tendra todo lo necesario para que 
//el objeto tenga comportamiento
public class PlayerController : MonoBehaviour
{
	public float velocity;
	public GameObject bala;
	public Puntuacion puntuacion;

	//VERSION 2D

	void Update(){

		float inputVertical;
		float yVelocity;

		inputVertical =Input.GetAxis("Vertical") * 10;
		yVelocity = rigidbody2D.velocity.y;
		yVelocity = inputVertical;
		rigidbody2D.velocity = new Vector2(0,yVelocity);
		
		if (Input.GetKeyDown("space")) {
        // Create a new bullet at “transform.position”
        // Which is the current position of the ship
        Instantiate(bala, transform.position, Quaternion.identity);
		//PONER CONTADOR PARA CONTROLAR NUMERO DE BALAS
		
		   }

	}
	void OnTriggerEnter2D(Collider2D triangulo){
		
		var nombre = triangulo.gameObject.name;
		if (nombre == "paredInferior" || nombre == "paredSuperior") {
			Destroy (gameObject);
			Application.LoadLevel("Gameover");
		}
	}
}