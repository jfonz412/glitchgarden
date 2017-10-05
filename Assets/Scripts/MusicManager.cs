using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {
	public AudioClip[] levelMusic;
	private AudioSource audioSource;

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad(gameObject);
		Debug.Log ("Don't destroy on load");
	}
	
	void Start(){
		audioSource = GetComponent<AudioSource>();
	}
	
	// Unity method
	void OnLevelWasLoaded(int level){
		AudioClip currentMusic = levelMusic[level];
		Debug.Log ("Playing clip " + currentMusic);
		if(currentMusic){
			audioSource.clip = currentMusic;
			audioSource.loop = true;
			audioSource.Play ();
		}
	}
}
