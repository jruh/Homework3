using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocker2 : MonoBehaviour
{

    //movement speed in units per second
    private float Speed = 5f;




    Vector3 pointA = new Vector3(25, -5, 0);
    Vector3 pointB = new Vector3(25, 25, 0);
    void Update()
    {
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 2));
    }
}
