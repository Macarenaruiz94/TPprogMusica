using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lyrics : MonoBehaviour
{
    public Text lyricPortion;
    public string[] lyrics;
    public float timeStamp = 0;
    public float timeSpeed;
    public float timeProgress;

    private void Start()
    {
        IncrementProgress(2.59f);
    }
    void Update()
    {
        if (timeStamp < timeProgress)
        {
            timeStamp += timeSpeed * Time.deltaTime;
        }
    }

    public void IncrementProgress(float newProgress)
    {
        timeProgress = timeStamp + newProgress;
    }

    public void UpdateLyrics()
    {
        if (timeStamp == 0.2f)
        {
            lyricPortion.text = lyrics[0];
        }
    }
}
