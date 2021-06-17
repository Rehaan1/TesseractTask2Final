using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class Dancer : MonoBehaviour
{
    public PlayableDirector playableDirector;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            PlayDancer();
        }
        if(Input.GetKeyDown(KeyCode.L))
        {
            StopDancer();
        }
    }
    
    public void PlayDancer()
    {
        playableDirector.Play();
    }

    public void StopDancer()
    {
        playableDirector.time=0;
        playableDirector.Stop();
        playableDirector.Evaluate();
    }


}
