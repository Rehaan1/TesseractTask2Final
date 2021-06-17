using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeSongText : MonoBehaviour
{

    [SerializeField] public TMP_Text songName;
    [SerializeField] public TMP_Text artist;
    [SerializeField] MusicPlayer musicPlayer;

    int SongIndex = 0;
    string currentRecordSong;
    string currentRecordArtist;

    void Start()
    {
        currentRecordSong = musicPlayer.currentRecord;
        currentRecordArtist = musicPlayer.currentArtist;
        songName.GetComponent<TMP_Text>().text = currentRecordSong;
        artist.GetComponent<TMP_Text>().text = currentRecordArtist;
    }

    // Update is called once per frame
    void Update()
    {
        currentRecordSong = musicPlayer.currentRecord;
        currentRecordArtist = musicPlayer.currentArtist;
        songName.GetComponent<TMP_Text>().text = currentRecordSong;
        artist.GetComponent<TMP_Text>().text = currentRecordArtist;
    }
}
