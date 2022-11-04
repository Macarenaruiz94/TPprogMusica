using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MuteToggle : MonoBehaviour
{
    public void MuteUpdate(bool muted)
    {
        if (muted == true)
        {
            AudioListener.volume = 0;
        }
        else AudioListener.volume = 1;
    }
}
