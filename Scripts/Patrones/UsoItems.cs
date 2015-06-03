using UnityEngine;
using System.Collections;
using System;

public class UsoItems{
	
	public static PlayerDDS aplicarCoinOne(PlayerDDS pl){
		PlayerDDS playerCoinOne = new DecoradorCoinOne(pl);
		return playerCoinOne;
	}
	
}