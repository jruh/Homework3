using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker1 : MonoBehaviour
{

    //movement speed in units per second
    private float Speed = 4f;

    
          
    
        Vector3 pointA = new Vector3(14, -2, 0);
        Vector3 pointB = new Vector3(14, 20, 0);
        void Update()
        {
            transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
        }
    }