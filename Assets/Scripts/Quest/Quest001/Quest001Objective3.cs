using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quest001Objective3 : MonoBehaviour
{
    public float TheDistance;
	public GameObject FakeSword;
	public GameObject RealSword;
	public GameObject ActionText;
	public GameObject ActionDisplay;
	public GameObject TheObjective;
	public int CloseObjective;
	public GameObject ChestBlock;
	public GameObject ExMark;
	public GameObject CompleteTrigger;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;

		if (CloseObjective == 3) {
			if (TheObjective.transform.localScale.y <= 0.0f) {
				CloseObjective = 0;
				TheObjective.SetActive (false);
			} else {
				TheObjective.transform.localScale -= new Vector3 (0.0f, 0.01f, 0.0f);
			}
		}
		
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			ActionDisplay.GetComponent<Text> ().text = "Take Sword";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
				this.GetComponent<BoxCollider> ().enabled = false;
				FakeSword.SetActive (false);
				RealSword.SetActive (true);
				ChestBlock.SetActive (true);
				TheObjective.SetActive (true);
				ExMark.SetActive (true);
				CompleteTrigger.SetActive (true);
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
