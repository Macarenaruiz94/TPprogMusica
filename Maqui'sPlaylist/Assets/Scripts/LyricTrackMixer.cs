using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class LyricTrackMixer : PlayableBehaviour
{
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        Text text = playerData as Text;
        string currentText = "";

        if (!text)
        {
            return;
        }

        int inputCount = playable.GetInputCount();

        for (int i = 0; i < inputCount; i++)
        {
            float inputWeight = playable.GetInputWeight(i);

            if(inputWeight > 0f)
            {
                ScriptPlayable<LyricBehaviour> inputPlayable = (ScriptPlayable<LyricBehaviour>)playable.GetInput(i);

                LyricBehaviour input = inputPlayable.GetBehaviour();

                currentText = input.lyricLine; ;
            }
        }

        text.text = currentText;
    }
}
