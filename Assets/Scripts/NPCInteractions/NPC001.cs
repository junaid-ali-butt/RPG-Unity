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
        TextBox.SetActive(true);
        NPCName.GetComponent<Text>().text="Tim";
        NPCName.SetActive(true);
        NPCText.GetComponent<Text>().text="Hello there! I have a quest for you! Should you accept it, please come back here later.";
        NPCText.SetActive(true);
        yield return new WaitForSeconds(5.5f);
        NPCName.SetActive(false);
        NPCText.SetActive(false);
        TextBox.SetActive(false);
        ActionDisplay.SetActive (true);
		ActionText.SetActive (true);
		MiniMap.SetActive (true);
    }
}
