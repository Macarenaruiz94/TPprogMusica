using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LyricClip : PlayableAsset
{
    public string lyricText;

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<LyricBehaviour>.Create(graph);

        LyricBehaviour lyricBehaviour = playable.GetBehaviour();
        lyricBehaviour.lyricLine = lyricText;

        return playable;
    }
}
