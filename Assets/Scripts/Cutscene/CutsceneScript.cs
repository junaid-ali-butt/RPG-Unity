using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneScript : MonoBehaviour
{
    public GameObject Camera01;
    public GameObject Camera02;
    public GameObject Camera03;
    public GameObject Player;
    public GameObject FadeIn;
    public GameObject FadeOut;
    public GameObject CutsceneText1;
    public GameObject CutsceneText2;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine (CutSceneStart());
    }

    IEnumerator CutSceneStart(){
        yield return new WaitForSeconds(5);
        Camera02.SetActive(true);
        CutsceneText1.SetActive(false);
        CutsceneText2.SetActive(false);
        Camera01.SetActive(false);
        FadeIn.SetActive(false);
        yield return new WaitForSeconds(10);
        Camera03.SetActive(true);
        Camera02.SetActive(false);
        yield return new WaitForSeconds(4);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        Player.SetActive(true);
        FadeIn.SetActive(true);
        FadeOut.SetActive(false);
        Camera03.SetActive(false);
        yield return new WaitForSeconds(1);
        FadeIn.SetActive(false);
    }
}
