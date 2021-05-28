using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC001 : MonoBehaviour
{
    public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject NPCName;
    public GameObject NPCText;
	public GameObject MiniMap;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			SwordBlocker.SwordBlock=1;
            ActionDisplay.GetComponent<Text>().text="Talk";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
                SwordBlocker.SwordBlock=2;
				MiniMap.SetActive (false);
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				//ThePlayer.SetActive (false);
				//Cursor.lockState = CursorLockMode.None;
				//Cursor.visible = true;
                StartCoroutine (NPC001Active());
			}
		}
	}

	void OnMouseExit() {
		SwordBlocker.SwordBlock=0;
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

    IEnumerator NPC001Active(){
		if(QuestManager.ActiveQuestNumber == 2){
        	NPCName.GetComponent<Text>().text="Tim";
        	NPCText.GetComponent<Text>().text="You're finally here. The spiders have taken over the town nearby. I need you to kill them and their boss.";
		}else{
        	NPCName.GetComponent<Text>().text="Tim";
        	NPCText.GetComponent<Text>().text="Hello there! I have a quest for you! Should you accept it, please come back here later.";
		}

		TextBox.SetActive(true);
		NPCName.SetActive(true);
		NPCText.SetActive(true);
		yield return new WaitForSeconds(5.5f);
        NPCName.SetActive(false);
        NPCText.SetActive(false);
        TextBox.SetActive(false);
		MiniMap.SetActive (true);
    }
}
