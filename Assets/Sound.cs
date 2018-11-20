using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound {
    public string name;
    public Audioclip clip;
    [Range(0f,1f)]
    public float volume;
    [Range(0f,1f)]
    public float pitch;

    [HideinInspector]
    public Audiosource source;

}
