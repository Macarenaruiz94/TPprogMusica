using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("AudioVolume", 1f);
        AudioListener.volume = slider.value;
    }

    public void VolumeUpdate(float value)
    {
        sliderValue = value;
        PlayerPrefs.SetFloat("AudioVolume", sliderValue);
        AudioListener.volume = slider.value;
    }
}
