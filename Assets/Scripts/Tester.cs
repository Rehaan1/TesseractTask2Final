using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    

    string currentRecord = "";
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.L))
        {
            FindObjectOfType<AudioManager>().Stop(currentRecord);
            currentRecord = "AAMusic";
            FindObjectOfType<AudioManager>().Play("AAMusic");
        }
        if(Input.GetKeyDown(KeyCode.K))
        {
            FindObjectOfType<AudioManager>().Stop(currentRecord);
            currentRecord = "NoWomanNoCry";
            FindObjectOfType<AudioManager>().Play("NoWomanNoCry");
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            FindObjectOfType<AudioManager>().Stop(currentRecord);
            currentRecord = "";
        }
        
    }
}
