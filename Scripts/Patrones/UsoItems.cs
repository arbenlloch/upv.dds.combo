using UnityEngine;
using System.Collections;
using System;

public class UsoItems{
	
	public static PlayerDDS aplicarCoinOne(PlayerDDS pl){
		PlayerDDS playerCoinOne = new DecoradorCoinOne(pl);
		Debug.Log ("Devolviendo un decoradorCoinOne");
		return playerCoinOne;
	}

	public static PlayerDDS aplicarCoinTwo(PlayerDDS pl){
		PlayerDDS playerCoinTwo = new DecoradorCoinTwo(pl);
		Debug.Log ("Devolviendo un decoradorCoinTwo");
		return playerCoinTwo;
	}
}