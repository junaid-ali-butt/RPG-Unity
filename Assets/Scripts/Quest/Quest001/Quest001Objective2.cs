using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Objective2 : MonoBehaviour
{
    public float TheDistance;
    public GameObject TreasureChest;
    public GameObject ActionText;
    public GameObject ActionDisplay;
    public GameObject TheObjective;
    public int CloseObjective;
    public GameObject TakeSword;
    
    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

        if(CloseObjective == 3){
            TheObjective.SetActive(true);
            if(TheObjective.transform.localScale.y <= 0.0f){
                CloseObjective=0;
                TheObjective.SetActive (false);
            }else{
                TheObjective.transform.localScale -= new Vector3 (0.0f, 0.01f, 0.0f);
            }
        }
    }

    void OnMouseOver() {
        if(TheDistance <=2){
            ActionDisplay.GetComponent<Text>().text="Open Chest";
            ActionDisplay.SetActive(true);
            ActionText.SetActive(true);
        }

        if(Input.GetButtonDown("Action")){
            if(TheDistance<=2){
                this.GetComponent<BoxCollider> ().enabled = false;
				TreasureChest.GetComponent<Animation> ().Play ("OpenChestAnim");
				TakeSword.SetActive (true);
				CloseObjective = 3;
				ActionText.SetActive (false);
				ActionDisplay.SetActive (false);
            }
        }
    }

    void OnMouseExit () {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}
}
