using UnityEngine;
using System.Collections;



public class LevelManager : MonoBehaviour {
	private float waitTime = 4.0f;
	
	void Update(){
		if (Time.realtimeSinceStartup >= waitTime){
			LoadLevel("Start Menu");
		}		
	}

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}
