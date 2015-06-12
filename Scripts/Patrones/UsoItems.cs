using UnityEngine;
using System.Collections;
using System;

public class UsoItems{
	
	public static PlayerController aplicarCoinOne(PlayerController pl){
		PlayerController pl2 = new DecoradorCoinOne(pl);
		return pl2;
	}
	
	public static PlayerController aplicarCoinTwo(PlayerController pl){
		PlayerController pl2 = new DecoradorCoinTwo(pl);
		return pl2;
	}
}