using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    float spincount;
    float degree;
    float spinspeed;

    bool isAntiClockwiseRotation = false;
    bool isClockwiseRotation = false;

    void Start () 
    {
        spincount = 36;
        degree = 180;
        spinspeed = 5;
    }
    void Update() 
    {
             
        if(Input.GetKeyDown (KeyCode.Space)) 
        {     
            spincount = 0; 
            isAntiClockwiseRotation = true;  
        }

        if(Input.GetKeyDown (KeyCode.L)) 
        {     
            spincount = 0; 
            isClockwiseRotation = true;  
        }

        if(isAntiClockwiseRotation)
        {
            forward(1);
        }
        if(isClockwiseRotation)
        {
            forward(-1);
        } 
             
    }

    void forward(int i)
    {   
        if (spincount < degree/spinspeed) 
        {
                transform.Rotate(i*Vector3.forward*spinspeed);
                spincount += 1;
        }
        else
        {
            isAntiClockwiseRotation = false;
            isClockwiseRotation = false;
        }
    }   

    public void RotateClockwise()
    {
        spincount = 0; 
        isClockwiseRotation = true;
    }

    public void RotateAntiClockwise()
    {
        spincount = 0; 
        isAntiClockwiseRotation = true;
    }
}

