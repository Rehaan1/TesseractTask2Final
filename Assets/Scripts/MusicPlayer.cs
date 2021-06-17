using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    [SerializeField] JsonReader jsonReader;
    [SerializeField] RecordRotator recordRotator1;
    [SerializeField] RecordRotator recordRotator2;
    public string currentRecord;
    public string currentArtist;
    bool isMusicStopped = true;
    bool isMusicPaused = true;
    int SongIndex=0;

    void Start()
    {
        currentRecord = jsonReader.mySongList.song[SongIndex].name;
        currentArtist = jsonReader.mySongList.song[SongIndex].artist;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
            PlayButton();
        if (Input.GetKeyDown(KeyCode.S))
            StopButton();
        if (Input.GetKeyDown(KeyCode.D))
            PauseButton();
        if(Input.GetKeyDown(KeyCode.N))
            NextButton();
        if(Input.GetKeyDown(KeyCode.P))
            PreviousButton();
    }

    public void PlayButton()
    {
            if (isMusicStopped || isMusicPaused)
            {
                FindObjectOfType<AudioManager>().Play(currentRecord);
                recordRotator1.isRotating = true;
                recordRotator2.isRotating = true;
                isMusicStopped = false;
                isMusicPaused = false;
            }
    }
    public void StopButton()
    {
            if (!isMusicStopped)
            {
                isMusicStopped = true;
                recordRotator1.isRotating = false;
                recordRotator2.isRotating = false;
                FindObjectOfType<AudioManager>().Stop(currentRecord);
            }
    }

    public void PauseButton()
    {
            if (!isMusicPaused)
            {
                isMusicPaused = true;
                recordRotator1.isRotating = false;
                recordRotator2.isRotating = false;
                FindObjectOfType<AudioManager>().Pause(currentRecord);
            }
    }


    public void NextButton()
    {
            SongIndex++;
            if (SongIndex == jsonReader.mySongList.song.Length)
            {
                SongIndex = 0;
            }
            FindObjectOfType<AudioManager>().Stop(currentRecord);
            
            currentRecord = jsonReader.mySongList.song[SongIndex].name;
            currentArtist = jsonReader.mySongList.song[SongIndex].artist;

            if (isMusicStopped || isMusicPaused)
            {
                return;
            }
            FindObjectOfType<AudioManager>().Play(currentRecord);
    }

    public void PreviousButton()
    {
            SongIndex--;
            if (SongIndex < 0)
            {
                SongIndex = jsonReader.mySongList.song.Length - 1;
            }
            FindObjectOfType<AudioManager>().Stop(currentRecord);
            
            currentRecord = jsonReader.mySongList.song[SongIndex].name;
            currentArtist = jsonReader.mySongList.song[SongIndex].artist;

            if (isMusicStopped || isMusicPaused)
            {
                return;
            }
            FindObjectOfType<AudioManager>().Play(currentRecord);
    }
    
}
