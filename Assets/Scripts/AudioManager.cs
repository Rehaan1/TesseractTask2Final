using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public List<Sound> sounds = new List<Sound>(); //Creating a list of sound
    public JsonReader jsonReader; //getting the Json Reader
    
    void Start()
    {
        foreach(JsonReader.Song s in jsonReader.mySongList.song)
        {
            Sound sound = new Sound(); //creating a sound
            sound.filename = s.filename; //storing the filename from JSON data
            sound.name = s.name;
            sound.artist = s.artist;
            sound.source = gameObject.AddComponent<AudioSource>(); //adding a audio source to it
            sound.source.clip = Resources.Load("TessMusicPlayer/"+s.filename) as AudioClip;  //getting the audio clip and assigning to AudioSource
            sound.source.volume = 1;
            sounds.Add(sound);
        }
    }

    public void Play(string name) //Plays respective song
    {
        Sound s = sounds.Find(sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Song: "+name+" Not Found");
            return;
        }
        s.source.Play();
    }

    public void Stop(string name) //Stops Playing respective song
    {
        Sound s = sounds.Find(sound => sound.name == name);
        if(s == null)
        {
            Debug.LogWarning("Song: "+name+" Not Found");
            return;
        }
        s.source.Stop();
    }
}
