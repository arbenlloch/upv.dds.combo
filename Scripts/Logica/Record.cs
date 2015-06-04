using UnityEngine;
using System.Collections;

public class Record : MonoBehaviour {
	
	public int record;
	public TextMesh textoRecord;
	private static Record objetoRecord=null;
	private static GameObject gameObjetoRecord=null;
	
	public int GetRecord(){
		
		return record;
		
	}
	
	public void SetRecord(int max){
		
		record = max;
		
	}
	
	public static Record ObjetoRecord(){
		
		if(objetoRecord== null){
			gameObjetoRecord = new GameObject ("Record");
			objetoRecord = gameObjetoRecord.AddComponent<Record>();
			//Tell unity not to destroy this object when loading a new scene!
			
		}
		return objetoRecord;
	}
	
	
	void Awake (){
		
	}
	// Use this for initialization
	void Start () {
		
		if (GameObject.Find ("Record") == null) {
			ObjetoRecord ();
		}
		
		ActualizarRecord();
		
		textoRecord.text = record.ToString ();
		
		
		
	}
	void ActualizarRecord (){
		
		Debug.Log ("El Record Anterior es " + record);
		if (Puntuacion.ObjetoPuntuacion ().puntuacion > record) 
			SetRecord(Puntuacion.ObjetoPuntuacion ().puntuacion);
		Debug.Log ("El Record " + record);
		
		
		
	}
	// Update is called once per frame
	void Update () {
		
	}
}
