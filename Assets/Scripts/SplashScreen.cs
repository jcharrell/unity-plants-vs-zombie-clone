using UnityEngine;
using System.Collections;

public class SplashScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke("LoadStartScreen", 2f);
	}

	void LoadStartScreen() {
		LevelManager levelManager = GameObject.Find("Level Manager").GetComponent<LevelManager>();
		levelManager.LoadNextLevel();
	}

}
