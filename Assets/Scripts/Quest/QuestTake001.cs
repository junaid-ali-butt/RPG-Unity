using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestTake001 : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject UIQuest;
	public GameObject ThePlayer;
	public GameObject NoticeCam;
    // public GameObject GameButtonManager;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				UIQuest.SetActive (true);
				NoticeCam.SetActive (true);
				ThePlayer.SetActive (false);
				Screen.lockCursor = false;
				Cursor.visible = true;
                // if(Input.GetKey("q")){
                //     GameButtonManager.GetComponent<Quest001Buttons>().AcceptQuest();
				// 	FindObjectOfType<Quest001Buttons>().AcceptQuest();
                // }
			}
		}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}


}
