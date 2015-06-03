using UnityEngine;
using System.Collections;

public class ItemCoinOne : MonoBehaviour
{	
	public ItemCoinOne(){
		this.destruido = false;
	}

	public int speed = -5;
	private bool destruido;
	private GameObject jugador;
	private PlayerController playerDecorandose;

	// Use this for initialization
	void Start ()
	{
//		NotificationCenter.DefaultCenter().AddObserver(this, "CambiarEstado");
//		/destruido = false;

		rigidbody2D.velocity = new Vector2 (speed, 0);
		Destroy(gameObject, 7);
	}
	

//	void CambiarEstado(Notification notification){ 
//		bool varCambioEstado = (bool)notification.data;	
//		destruido = true;//MODIFICAR
//		Debug.Log (destruido);
//	}

	public bool getDestruido(){
		return this.destruido;
	}

	public void setDestruido(bool d){
		this.destruido = d;
	}

	void  OnTriggerEnter2D(Collider2D obj){
		var name = obj.gameObject.name;
		
		if (name == "triangulo") {

			destruido = true;
			jugador = GameObject.Find ("triangulo");
			playerDecorandose = jugador.GetComponent<PlayerController>();
			playerDecorandose.setMonedaUnoEstado(destruido);
//			playerDecorandose.setTiempoCoinOne(playerDecorandose.getTiempoCoinOne()-Time.realtimeSinceStartup);

			Destroy (gameObject);
			
			//Lanzamos Gameover
		}

		/*if (name == "bullet(Clone)") {
			//Desturye Bala o el jugador
			Destroy(obj.gameObject);
		}*/
	}
}