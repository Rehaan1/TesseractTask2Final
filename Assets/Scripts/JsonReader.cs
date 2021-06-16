using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JsonReader : MonoBehaviour
{
    public TextAsset songDataJSON; //JSON File that conains the Song Details

    [System.Serializable]
    public class Song //description of song
    {
        public string name;
        public string artist;
        public string filename;
    }

    [System.Serializable]
    public class SongList //List of Song
    {
        public Song[] song;
    }

    public SongList mySongList = new SongList(); 

    void Awake()
    {
        mySongList = JsonUtility.FromJson<SongList>(songDataJSON.text); //Get Data From JSON and put in array
        //foreach(Song song in mySongList.song)
        //{
        //    Debug.Log(song.filename);
        ///}
    }
}
