﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntiClock : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    public void Rotate2()
    {
        transform.Rotate(0, 0, -20 * Time.deltaTime);
    }
}
