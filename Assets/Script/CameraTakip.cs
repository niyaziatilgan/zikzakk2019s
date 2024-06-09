using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTakip : MonoBehaviour
{
    public Transform BallLocation;
    Vector3 fark;
    
    void Start()
    {
        fark = transform.position - BallLocation.position;
    }

    
    void Update()
    {
        if(TopMovement.fall == false)
        {
            transform.position = BallLocation.position + fark;
        }
        
    }
}
