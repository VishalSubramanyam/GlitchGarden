using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPrefsManager : MonoBehaviour
{
	const string MASTER_VOLUME_KEY = "master_volume";
	const string DIFFICULTY_KEY = "difficulty";
	const string LEVEL_KEY = "level_unlocked_";

	public static float MasterVolume {
		get {
			return PlayerPrefs.GetFloat (MASTER_VOLUME_KEY);
		}
		set {
			if (value <= 1f && value > 0f) {
				PlayerPrefs.SetFloat (MASTER_VOLUME_KEY, value);
			} else {
				print ("Master volume out of range");
			}
		}
	}

	public static void UnlockLevel (int level)
	{
		if (level <= SceneManager.sceneCountInBuildSettings - 1) {
			PlayerPrefs.SetInt (LEVEL_KEY + level.ToString (), 1);
		} else {
			print ("Too bad buddy");
		}
	}


	public static bool IsLevelUnlocked (int level)
	{
		int levelValue = PlayerPrefs.GetInt (LEVEL_KEY + level.ToString ());
		bool isLevelUnlocked = (levelValue == 1);
		if (level <= SceneManager.sceneCountInBuildSettings - 1) {
			return isLevelUnlocked;
		} else {
			Debug.LogError ("Level Unlock Check failed for obvious reasons.");
			return false;
		}
	}


	public static float difficulty {
		get {
			return PlayerPrefs.GetFloat (DIFFICULTY_KEY);
		}
		set {
			try {
				if (value > 0f && value <= 1f)
					PlayerPrefs.SetFloat (DIFFICULTY_KEY, value);
				else
					Debug.LogError ("Difficult set failed for you-know-what reason.");
			} catch (PlayerPrefsException e) {
				Debug.LogError (e.Message);
			}
		}
	}


	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
