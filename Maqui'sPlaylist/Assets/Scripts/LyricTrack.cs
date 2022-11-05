using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Timeline;
using UnityEngine.Playables;

[TrackBindingType(typeof(Text))]
[TrackClipType(typeof(LyricClip))]
public class LyricTrack : TrackAsset
{
    public override Playable CreateTrackMixer(PlayableGraph graph, GameObject go, int inputCount)
    {
        return ScriptPlayable<LyricTrackMixer>.Create(graph, inputCount);
    }
}
