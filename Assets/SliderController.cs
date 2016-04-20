using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
	public Slider volSlider;
	public Slider difSlider;
	// Use this for initialization
	void Start ()
	{
		volSlider.value = PlayerPrefsManager.MasterVolume * 100;
		difSlider.value = PlayerPrefsManager.difficulty;
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
