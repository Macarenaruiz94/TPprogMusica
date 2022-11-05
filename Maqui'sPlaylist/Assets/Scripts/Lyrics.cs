using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lyrics : MonoBehaviour
{
    public GameObject[] lyrics;
    public float[] timeStamp;
    public float timer = 0;
    public float timeSpeed;
    public float timeProgress;

    private void Start()
    {
        for (int i = 0; i < lyrics.Length; i++)
        {
            lyrics[i].SetActive(false);
        }

        IncrementProgress(3.01f);
    }
    void Update()
    {
        if (timer < timeProgress)
        {
            timer += timeSpeed * Time.deltaTime;
        }
    }

    public void IncrementProgress(float newProgress)
    {
        timeProgress = timer + newProgress;
    }

    public void UpdateLyrics()
    {
        if (timer == timeStamp[0])
        {
            lyrics[0].gameObject.SetActive(true);
        }
    }
}
