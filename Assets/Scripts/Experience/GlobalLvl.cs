using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalLvl : MonoBehaviour
{
    public static int CurrentLevel = 1;
    public int InternalLevel;

    // Update is called once per frame
    void Update()
    {
        InternalLevel = CurrentLevel;
    }
}
