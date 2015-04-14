using UnityEngine;
using System.Collections;

public class T01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//Debug.Log (a + 65);
		double[] vectorDoubleOne = {2.3, 52.1};
	    double[,] vectorDoubleTwo = new double[3,2];
		//vectorDoubleTwo = { {1, 2}, {3, 4}, {5, 6} };
		Debug.Log(vectorDoubleTwo[2,0]);
	}
}