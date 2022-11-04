using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public bool isMuted;

    private void Start()
    {
        isMuted = false;
    }
    public void MuteUpdate()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;

        SaveMuteData();
    }

    public void SaveMuteData()
    {
        PlayerPrefs.SetInt("AudioMute", (isMuted ? 1 : 0));
    }
}
