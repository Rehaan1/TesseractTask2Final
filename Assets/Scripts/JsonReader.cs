using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public TextAsset songDataJSON; //JSON File that conains the Song Details

    [System.Serializable]
    public class Song
    {
        public string name;
        public string artist;
        public string filename;
    }

    [System.Serializable]
    public class SongList
    {
        public Song[] song;
    }

    public SongList mySongList = new SongList();

    void Start()
    {
        mySongList = JsonUtility.FromJson<SongList>(songDataJSON.text);
        foreach(Song song in mySongList.song)
        {
            Debug.Log(song.name);
            Debug.Log(song.artist);
            Debug.Log(song.filename);
        }
    }
}
