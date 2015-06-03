using UnityEngine;
using System.Collections;

public class ItemCoinTwo : MonoBehaviour
{
	public int speed = -5;
	private bool destruido2;
	private GameObject jugador;
	private PlayerController playerDecorandose2;

	public ItemCoinTwo(){
		this.destruido2 = false;
	}

	// Use this for initialization
	void Start ()
	{
		rigidbody2D.velocity = new Vector2 (speed, 0);
		Destroy(gameObject, 7);
	}

	public bool getDestruido(){
		return this.destruido2;
	}

	public void setDestruido(bool d){
		this.destruido2 = d;
	}

	void OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;

		if (name == "triangulo") {
			destruido2 = true;
			jugador = GameObject.Find ("triangulo");
			playerDecorandose2 = jugador.GetComponent<PlayerController>();
			playerDecorandose2.setMonedaDosEstado(destruido2);

			Destroy (gameObject);
		}
		
		if (name == "bullet(Clone)") {
			//Desturye Bala o el jugador
			Destroy(obj.gameObject);
		}
	}
}