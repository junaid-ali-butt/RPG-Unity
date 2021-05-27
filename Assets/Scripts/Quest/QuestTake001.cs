using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestTake001 : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject UIQuest;
	public GameObject ThePlayer;
	public GameObject NoticeCam;
	public GameObject MiniMap;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			SwordBlocker.SwordBlock=1;
			ActionDisplay.GetComponent<Text>().text = "View Quest";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
				ActionDisplay.SetActive (false);
				MiniMap.SetActive (false);
				ActionText.SetActive (false);
				SwordBlocker.SwordBlock=2;
				UIQuest.SetActive (true);
				NoticeCam.SetActive (true);
				ThePlayer.SetActive (false);
				Cursor.lockState = CursorLockMode.None;
				Cursor.visible = true;
			}
		}
	}

	void OnMouseExit() {
		SwordBlocker.SwordBlock=0;
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}


}
