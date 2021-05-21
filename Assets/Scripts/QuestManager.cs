using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestManager : MonoBehaviour {

	public static int ActiveQuestNumber;
	public int InternalQuestNumber;
	public static int SubQuestNumber;
	public int InternalSubQuestNumber;
	public GameObject MainMark;
	public GameObject Object01Mark;
	public GameObject Object02Mark;
	public GameObject Object03Mark;
	public GameObject Pointer;

	void Update () {
		InternalQuestNumber = ActiveQuestNumber;
		InternalSubQuestNumber = SubQuestNumber;
		Pointer.transform.LookAt(MainMark.transform);
		if(InternalSubQuestNumber == 0){
			Pointer.SetActive(false);
		}else{
			Pointer.SetActive(true);
		}

		if(InternalSubQuestNumber == 1){
			MainMark.transform.position = Object01Mark.transform.position;
		}

		if(InternalSubQuestNumber == 2){
			MainMark.transform.position = Object02Mark.transform.position;
		}

		if(InternalSubQuestNumber == 3){
			MainMark.transform.position = Object03Mark.transform.position;
		}
	}

}