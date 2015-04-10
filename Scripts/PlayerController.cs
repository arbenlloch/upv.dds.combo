using UnityEngine;
using System.Collections;

//Constructor de extends los dos puntos. El MonoBehaviour sera el padre que tendra todo lo necesario para que 
//el objeto tenga comportamiento
public class PlayerController : MonoBehaviour
{
	public float velocity;
	public GameObject bala;
	public bool choca = false;
	//VERSION 2D

	void Start(){
		collider2D.isTrigger = choca;
	}
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
		
		//rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x,3);
	}

	void OnTriggerEnter2D(Collider2D triangulo)
	{

		var nombre = triangulo.gameObject.name;
		if (nombre == "paredInferior" || nombre == "paredSuperior") {
			Destroy(gameObject);
		}
	}
}
	//VERSION 3D
	/**
	 * 
	 * [System.Serializable]
	public class Boundary
	{
		public float xMin, xMax, zMin, zMax;
	}
	
	public float speed;
	public float tilt;
	public Boundary boundary;

	void FixedUpdate () //TIENE QUE VER CON DELTATIME PARA QUE EL JUEGO TENGA UN TIEMPO DE EJECUCION NORMALIZADO
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		//NOS INTERESA EL MOVIMIENTO VERTICAL, 
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		rigidbody.velocity = movement * speed;

		/** SIRVER PARA LIMITAR EL ESPACIO DEL PLAYER EN LA PANTALL, EN NUESTRO CASO SON LIMITADAS POR COLLIDERS
		rigidbody.position = new Vector3 
			(
				/Mathf.Clamp (rigidbody.position.x, boundary.xMin, boundary.xMax), 
				0.0f, 
				Mathf.Clamp (rigidbody.position.z, boundary.zMin, boundary.zMax)
				);

		//Quaternion se usa para transformar vectores 3d.
		//rigidbody.rotation = Quaternion.Euler (0.0f, 0.0f, rigidbody.velocity.x * -tilt);
	}
	*/
