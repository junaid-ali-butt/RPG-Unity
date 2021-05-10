using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    public GameObject SwordObject;
    public int SwordStatus;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && SwordStatus==0 && SwordBlocker.SwordBlock==0){
            StartCoroutine(SwordSwingStatus());
        }
    }

    IEnumerator SwordSwingStatus (){
        SwordStatus=1;
        SwordObject.GetComponent<Animation>().Play();
        SwordStatus=2;
        yield return new WaitForSeconds(1.0f);
        SwordStatus=0;
    }
}
