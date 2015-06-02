using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {

	// Use this for initialization
	public bool paused = false;
	


	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Escape)){

			if (paused){

				paused = false;
				Time.timeScale = 1;
			}
			else{
				paused = true;
				Time.timeScale = 0;
			}
		}
	}
}
