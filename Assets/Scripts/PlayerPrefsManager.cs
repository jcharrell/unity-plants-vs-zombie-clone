using UnityEngine;
using System.Collections;

public class PlayerPrefsManager : MonoBehaviour {

	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";
	
	public static void SetMasterVolume(float value) {
		if (FloatIsInRange(value)) {
			PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, value);		
		} else {
			Debug.LogError("Master volume out of range");
		}
	}
	
	public static float GetMasterVolume() {
		return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
	}
	
	
	public static void UnlockLevel(int level) {
		if(level <= Application.levelCount - 1) {
			// An integer value of 1 will indicate that the level is unlocked
			PlayerPrefs.SetInt(LEVEL_KEY + level.ToString(), 1);
		} else {
			Debug.LogError("Level number out of range");
		}
	}
	
	public static bool IsLevelUnlocked(int level) {
		if(level <= Application.levelCount - 1) {
			int levelStatus = PlayerPrefs.GetInt(LEVEL_KEY + level.ToString());
			return (levelStatus == 1);
		} else {
			Debug.LogError("Level number out of range");
			return false;
		}
	}
	
	
	public static void SetDifficulty(float value) {	
		if (FloatIsInRange(value)) {
			PlayerPrefs.SetFloat(DIFFICULTY_KEY, value);
		} else {
			Debug.LogError("Difficulty value out of range");
		}
	}
	
	public static float GetDifficulty() {
		return PlayerPrefs.GetFloat(DIFFICULTY_KEY);
	}
	
	
	private static bool FloatIsInRange(float value) {
		return (value >= 0f && value <= 1f);
	}
	
}
