using UnityEngine;
using System.Collections;

public class MusicManager : MonoBehaviour
{
	public AudioClip[] musics;
	private AudioSource audSource;
	// Use this for initialization
	void Awake ()
	{
		DontDestroyOnLoad (gameObject);
		audSource = GetComponent<AudioSource> ();
	}

	/// <summary>
	/// Raises the level was loaded event.
	/// </summary>
	/// <param name="level">Level.</param>
	void OnLevelWasLoaded (int level)
	{
		audSource.clip = musics [level - 1];
		audSource.loop = true;
		if (audSource.clip == musics [3])
			audSource.loop = false;
		audSource.Play ();
	}
}
