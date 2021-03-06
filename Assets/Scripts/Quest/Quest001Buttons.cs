using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Quest001Buttons : MonoBehaviour {

	public GameObject ThePlayer;
	public GameObject NoticeCam;
	public GameObject UIQuest;
	public GameObject ActiveQuestBox;
	public GameObject Objective01;
	public GameObject Objective02;
	public GameObject Objective03;
	public GameObject ExMark;
	public GameObject NoticeTrigger;
	public GameObject QuestNotice;
	public GameObject MiniMap;

	public void AcceptQuest () {
		QuestManager.SubQuestNumber=1;
		ThePlayer.SetActive (true);
		MiniMap.SetActive (true);
		NoticeCam.SetActive (false);
		UIQuest.SetActive (false);
		StartCoroutine(SetQuestUI());
	}

	IEnumerator SetQuestUI() {
		ActiveQuestBox.GetComponent<Text> ().text = "My First Weapon";
		Objective01.GetComponent<Text> ().text = "Reach the clearing in the wood";
		Objective02.GetComponent<Text> ().text = "Open the chest";
		Objective03.GetComponent<Text> ().text = "Retrieve the weapon";
		QuestManager.ActiveQuestNumber = 1;
		QuestNotice.SetActive(false);
		NoticeTrigger.SetActive(false);
		ExMark.SetActive(false);
		yield return new WaitForSeconds (0.5f);
		ActiveQuestBox.SetActive (true);
		yield return new WaitForSeconds (1);
		Objective01.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		Objective02.SetActive (true);
		yield return new WaitForSeconds (0.5f);
		Objective03.SetActive (true);
		yield return new WaitForSeconds (9);
		ActiveQuestBox.SetActive (false);
		Objective01.SetActive (false);
		Objective02.SetActive (false);
		Objective03.SetActive (false);
	}

	public void DeclineQuest() {
		ThePlayer.SetActive (true);
		MiniMap.SetActive (true);
		NoticeCam.SetActive (false);
		UIQuest.SetActive (false);
	}

}