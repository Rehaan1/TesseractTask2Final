using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordRotator : MonoBehaviour
{
    public bool isRotating = false;
    [SerializeField] float speed=10f;
    void Update()
    {
        if(isRotating)
            transform.Rotate(0,Time.deltaTime * speed,0);
    }
}
