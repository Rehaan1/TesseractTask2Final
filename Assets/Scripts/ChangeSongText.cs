using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeSongText : MonoBehaviour
{

    //@TODO Get Song Name From MusicPlayer Instead of Json Reader


    [SerializeField] public TMP_Text songName;
    [SerializeField] public TMP_Text artist;
    [SerializeField] JsonReader jsonReader;

    int SongIndex = 0;
    string currentRecordSong;
    string currentRecordArtist;

    void Start()
    {
        currentRecordSong = jsonReader.mySongList.song[SongIndex].name;
        currentRecordArtist = jsonReader.mySongList.song[SongIndex].artist;
        songName.GetComponent<TMP_Text>().text = currentRecordSong;
        artist.GetComponent<TMP_Text>().text = currentRecordArtist;
    }

    // Update is called once per frame
    void Update()
    {
        songName.GetComponent<TMP_Text>().text = currentRecordSong;
        artist.GetComponent<TMP_Text>().text = currentRecordArtist;

        if (Input.GetKeyDown(KeyCode.N))
        {
            SongIndex++;
            if (SongIndex == jsonReader.mySongList.song.Length)
            {
                SongIndex = 0;
            }
            
            currentRecordSong = jsonReader.mySongList.song[SongIndex].name;
            currentRecordArtist = jsonReader.mySongList.song[SongIndex].artist;
            
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SongIndex--;
            if (SongIndex < 0)
            {
                SongIndex = jsonReader.mySongList.song.Length - 1;
            }
            currentRecordSong = jsonReader.mySongList.song[SongIndex].name;
            currentRecordArtist = jsonReader.mySongList.song[SongIndex].artist;
        }
    }
}
