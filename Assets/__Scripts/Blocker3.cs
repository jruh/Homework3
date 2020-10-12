using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker3 : MonoBehaviour
{

    //movement speed in units per second
    private float Speed = 10f;




    Vector3 pointA = new Vector3(30, 3, 0);
    Vector3 pointB = new Vector3(30, 17, 0);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
