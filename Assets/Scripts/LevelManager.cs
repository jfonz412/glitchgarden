using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public float waitTime;

	void Start () {
		if (waitTime == 0.0){
			Debug.Log ("Level auto load disabled");
		}else{
			Invoke ("LoadNextLevel", waitTime);
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
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
}
