using UnityEngine;
using System.Collections;

public class PrefsTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//test master volume
		PlayerPrefsManager.SetMasterVolume(0.5f);
		print ("what is the master volume?");
		Debug.Log(PlayerPrefsManager.GetMasterVolume());
	
		//test level unlock (will be unlocked until again locked)
		Debug.Log (PlayerPrefsManager.IsLevelUnlocked(1));
		Debug.Log (PlayerPrefsManager.IsLevelUnlocked(2));
		PlayerPrefsManager.UnlockLevel(1);
		PlayerPrefsManager.UnlockLevel(2);
		print ("is level 1 unlocked?");
		Debug.Log (PlayerPrefsManager.IsLevelUnlocked(1));
		print ("is level 2 unlocked?");
		Debug.Log (PlayerPrefsManager.IsLevelUnlocked(2));
		
		PlayerPrefsManager.SetDifficultyLevel(1.8f);
		print ("what is the difficulty level?");
		Debug.Log(PlayerPrefsManager.GetDifficultyLevel());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
