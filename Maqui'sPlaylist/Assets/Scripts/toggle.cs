using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle : MonoBehaviour
{
    public bool muteOn;

    public void OnOff()
    {
        PlayerPrefs.SetInt("Music", (muteOn ? 1 : 0));
    }
}
