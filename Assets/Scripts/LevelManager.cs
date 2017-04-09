using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
	public float autoLoadNextLevelAfter = 0;

	void Start() {
		if(autoLoadNextLevelAfter == 0) {
			Invoke("LoadNextLevel", autoLoadNextLevelAfter);
		}
	}

	public void LoadLevel(string name) {		
		Application.LoadLevel (name);
	}
	
	public void LoadNextLevel() {
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void CheckWinCondition() {
			LoadNextLevel();
	}
	public void QuitGame() {
		Application.Quit();
	}
}
