﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalExp : MonoBehaviour
{
    public static int CurrentExp;
    public int InternalExp;

    // Update is called once per frame
    void Update()
    {
        InternalExp=CurrentExp;
    }
}
