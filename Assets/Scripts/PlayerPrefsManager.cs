using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	
	//Set a float via Unity's Player Prefs
	public static void SetMasterVolume(float volume){

		if (volume >= 0f && volume <= 1f){
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
		}else {
			Debug.LogError("Invalid volume input");
		}
	}
	
	//Return a float via Unity's Player Prefs
	public static float GetMasterVolume(){
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}
	
	public static void UnlockLevel(int level){
		if (level <= Application.levelCount - 1){
			//sets string to LEVEL_KEY2, the '1' == true
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1);
		}else{
			Debug.LogError("Invalid level input (UnlockLevel)");
		}
	}
	
	//here we check to see if the level we pass in returns 1 or null
	public static bool IsLevelUnlocked(int level){
		int levelValue = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
		bool isLevelUnlocked = (levelValue == 1); //will be true if levelValue == 1
		
		if (level <= Application.levelCount - 1){
			return isLevelUnlocked;
		}else{
			Debug.LogError("Invalid level input (IsLevelUnlocked)");
			return false;
		}
	}
	
	public static void SetDifficultyLevel(float difficultyLevel){
		if (difficultyLevel >= 0f && difficultyLevel <= 1f){
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, difficultyLevel);
		}else{
			Debug.LogError("Invalid difficulty setting");
		}
	}
	
	public static float GetDifficultyLevel(){
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	
}
