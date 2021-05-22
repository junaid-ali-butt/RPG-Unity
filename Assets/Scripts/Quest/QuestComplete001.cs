using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestComplete001 : MonoBehaviour {

	public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
	public GameObject ExMark;
	public GameObject CompleteTrigger;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			ActionDisplay.GetComponent<Text>().text = "Complete Quest";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
				QuestManager.SubQuestNumber=0;
				ActionDisplay.SetActive (false);
				ActionText.SetActive (false);
				ExMark.SetActive (false);
				CompleteTrigger.SetActive(false);
				GlobalExp.CurrentExp += 100;
				GlobalCash.GoldAmount += 100;
				PlayerPrefs.SetInt("GoldAmountSave", GlobalCash.GoldAmount);
				QuestManager.ActiveQuestNumber = 2;
			}
		}
	}

	void OnMouseExit() {
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}


}
