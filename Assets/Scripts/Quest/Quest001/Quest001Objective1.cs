using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Objective1 : MonoBehaviour
{
    public GameObject TheObjective;
    public int CloseObjective;

    // Update is called once per frame
    void Update()
    {
        if(CloseObjective == 1){
            if(TheObjective.transform.localScale.y <= 0.0f){
                CloseObjective = 0;
                TheObjective.SetActive(false);
            }else{
                TheObjective.transform.localScale -= new Vector3 (0.0f, 0.1f, 0.0f);
            }
        }
    }

    void OnTriggerEnter(){
        QuestManager.SubQuestNumber=2;
        GetComponent<BoxCollider>().enabled = false;
        StartCoroutine (FinishObjective());
        // gameObject.SetActive(false);
    }

    IEnumerator FinishObjective(){
        TheObjective.SetActive(true);
        yield return new WaitForSeconds(1f);
        CloseObjective=1;
        // gameObject.SetActive(false);
    }
}
