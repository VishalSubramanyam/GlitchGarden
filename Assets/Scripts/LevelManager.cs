using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public float delay;
	public bool shouldILoadTheNextLevel;
	private MusicManager musicManager;

	void Start ()
	{
		if (shouldILoadTheNextLevel) {
			musicManager = GameObject.FindObjectOfType<MusicManager> () as MusicManager;
			Invoke ("LoadNextLevel", delay);
			if (PlayerPrefsManager.difficulty == 0 && PlayerPrefsManager.MasterVolume == 0) {
				PlayerPrefsManager.difficulty = 0.5f;
				PlayerPrefsManager.MasterVolume = 0.5f;
				if (musicManager) {
					musicManager.gameObject.GetComponent<AudioSource> ().volume = PlayerPrefsManager.MasterVolume;
				}
			}
		}
	}

	public void LoadLevel (string name)
	{
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene (name);
		Cursor.visible = true;
	}

	public void QuitRequest ()
	{
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

	public void LoadNextLevel ()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
