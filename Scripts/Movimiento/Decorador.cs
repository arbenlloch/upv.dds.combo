using UnityEngine;
using System.Collections;

public abstract class Decorador : PlayerDDS{
	
	protected PlayerDDS playerDecorador;
	
	//UNITY TE EXIGE CONSTRUCTOR VACIO
	
	public Decorador(PlayerDDS pla){
		
		this.playerDecorador = pla;
	}
	
	public virtual void funcionalidad(){
		playerDecorador.funcionalidad();
	}
}