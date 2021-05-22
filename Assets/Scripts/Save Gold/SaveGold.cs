using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGold : MonoBehaviour
{
    public int LoadGold;

    // Start is called before the first frame update
    void Start()
    {
        LoadGold = PlayerPrefs.GetInt("GoldAmountSave");
    }
}
