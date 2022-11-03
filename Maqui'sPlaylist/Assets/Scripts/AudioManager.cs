using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public string parameterName;

    public Toggle audioToggle;

    public AudioMixer audioMixer;

    private float audioDB;


    public void Start()
    {
        audioToggle.isOn = PlayerPrefs.GetInt(parameterName) == 1 ? true : false;
        audioMixer.GetFloat(parameterName, out audioDB);
        audioMixer.SetFloat(parameterName, audioToggle.isOn ? audioDB : -80);
        audioToggle.onValueChanged.AddListener(ToggleAudio);
    }

    public void ToggleAudio(bool isOn)
    {
        if (isOn)
            audioMixer.SetFloat(parameterName, audioDB);

        else
            audioMixer.SetFloat(parameterName, -80);

        PlayerPrefs.SetInt(parameterName, isOn ? 1 : 0);
    }
}
