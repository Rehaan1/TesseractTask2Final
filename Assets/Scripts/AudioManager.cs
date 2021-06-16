using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<Sound> sounds = new List<Sound>();
    public JsonReader jsonReader;
    
    void Start()
    {
        foreach(JsonReader.Song s in jsonReader.mySongList.song)
        {
            Sound sound = new Sound();
            sound.filename = s.filename;
            sound.name = s.name;
            sound.artist = s.artist;
            sound.source = gameObject.AddComponent<AudioSource>();
            sound.source.clip = Resources.Load("TessMusicPlayer/"+s.filename) as AudioClip;
            sound.source.volume = 1;
            sounds.Add(sound);
        }
    }

    public void Play(string name)
    {
        Sound s = sounds.Find(sound => sound.filename == name);
        if(s == null)
        {
            Debug.LogWarning("Song: "+name+" Not Found");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name)
    {
        Sound s = sounds.Find(sound => sound.filename == name);
        if(s == null)
        {
            Debug.LogWarning("Song: "+name+" Not Found");
            return;
        }
        s.source.Stop();
    }
}
