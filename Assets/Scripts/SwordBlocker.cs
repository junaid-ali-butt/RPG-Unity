using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordBlocker : MonoBehaviour
{
    public static int SwordBlock;
    public int InternalBlock;

    // Update is called once per frame
    void Update()
    {
        InternalBlock=SwordBlock;
    }
}
