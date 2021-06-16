using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    public JsonReader jsonReader;
    string currentRecord;
    bool isMusicStopped = true;
    int SongIndex=0;

    void Start()
    {
        currentRecord = jsonReader.mySongList.song[SongIndex].name;
    }

    void Update()
    {
        PlayButton();
        StopButton();
        NextButton();
        PreviousButton();
    }

    void PlayButton()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (isMusicStopped)
            {
                FindObjectOfType<AudioManager>().Play(currentRecord);
                isMusicStopped = false;
            }
        }
    }
    void StopButton()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            if (!isMusicStopped)
            {
                isMusicStopped = true;
                FindObjectOfType<AudioManager>().Stop(currentRecord);
            }
        }
    }


    void NextButton()
    {
        if (Input.GetKeyDown(KeyCode.N))
        {
            SongIndex++;
            if (SongIndex == jsonReader.mySongList.song.Length)
            {
                SongIndex = 0;
            }
            FindObjectOfType<AudioManager>().Stop(currentRecord);
            currentRecord = jsonReader.mySongList.song[SongIndex].name;

            if (!isMusicStopped)
            {
                FindObjectOfType<AudioManager>().Play(currentRecord);
            }

        }
    }

    void PreviousButton()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SongIndex--;
            if (SongIndex < 0)
            {
                SongIndex = jsonReader.mySongList.song.Length - 1;
            }
            FindObjectOfType<AudioManager>().Stop(currentRecord);
            currentRecord = jsonReader.mySongList.song[SongIndex].name;

            if (!isMusicStopped)
            {
                FindObjectOfType<AudioManager>().Play(currentRecord);
            }
        }
    }
    
}
