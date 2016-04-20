using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
	public Slider volumeSlider;
	public Slider difficultySlider;
	private MusicManager musicManager;
	// Use this for initialization
	void Start ()
	{
		musicManager = GameObject.FindObjectOfType<MusicManager> () as MusicManager;
	}
	
	// Update is called once per frame
	void Update ()
	{
	 
	}

	public void Save ()
	{
		PlayerPrefsManager.MasterVolume = volumeSlider.value / 100;
		PlayerPrefsManager.difficulty = difficultySlider.value;
		if (musicManager) {
			musicManager.gameObject.GetComponent<AudioSource> ().volume = PlayerPrefsManager.MasterVolume;
		}
		Debug.Log (PlayerPrefsManager.MasterVolume);
		Debug.Log (PlayerPrefsManager.difficulty);
	}
}
