using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour {

	public AudioClip[] levelMusicChangeArr;
	private AudioSource audioSource;

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	void Awake() {
		DontDestroyOnLoad(gameObject);
	}

	void OnLevelWasLoaded(int level) {
		AudioClip levelMusic = levelMusicChangeArr[level];

		if(levelMusic) {
			audioSource.clip = levelMusic;
			audioSource.loop = true;
			audioSource.Play();
		}
	}
}
