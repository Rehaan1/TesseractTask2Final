using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class Sound 
{
    public string name;
    public AudioClip clip;
    public string artist;
    public string filename;

    [Range(0,1)]
    public float volume;

    [HideInInspector]
    public AudioSource source;
}
