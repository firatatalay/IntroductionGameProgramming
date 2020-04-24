﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorTest : MonoBehaviour
{
    public Transform p1Transform;
    public Transform p2Transform;

    Vector3 point1;
    Vector3 point2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        point1 = p1Transform.position;
        point2 = p2Transform.position;

        float magnitute = Mathf.Sqrt(Mathf.Pow(point1.x, 2) + Mathf.Pow(point1.y, 2));

        Vector3 unitPoint1 = point1 / point1.magnitude;
        //point1.normalized = point1 / point1.magnitude;


        Debug.Log(unitPoint1);
        //Debug.Log(point1.magnitude); //hazır fonksiyon aynı hesaplamayı yapar.

        Debug.DrawLine(Vector3.zero, point1, Color.red);
        Debug.DrawLine(Vector3.zero, point2, Color.blue);
        Debug.DrawLine(Vector3.zero, point1+point2, Color.magenta);
        Debug.DrawLine(Vector3.zero, point1-point2, Color.black);


        Debug.DrawLine(Vector3.zero, unitPoint1, Color.green); //Debug.Log(point1.normalized);
    }
}