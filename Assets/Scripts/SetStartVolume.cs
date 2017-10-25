using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {
	private MusicManager musicManager;
	private AudioSource audioSource;
	
	// Use this for initialization
	void Start () {
		float volume = PlayerPrefsManager.GetMasterVolume();
		musicManager = FindObjectOfType<MusicManager>();
		musicManager.ChangeVolume(volume);
	}
}
