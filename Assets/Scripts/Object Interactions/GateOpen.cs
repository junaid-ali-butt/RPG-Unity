using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GateOpen : MonoBehaviour
{
    public float TheDistance;
	public GameObject ActionDisplay;
	public GameObject ActionText;
    public GameObject LeftGate;
    public GameObject RightGate;

	void Update () {
		TheDistance = PlayerCasting.DistanceFromTarget;
	}

	void OnMouseOver () {
		if (TheDistance <= 3) {
			SwordBlocker.SwordBlock=1;
            ActionDisplay.GetComponent<Text>().text="Open Gate";
			ActionDisplay.SetActive (true);
			ActionText.SetActive (true);
		}

		if (Input.GetButtonDown ("Action")) {
			if (TheDistance <= 3) {
                StartCoroutine (OpenTownGate());
			}
		}
	}

	void OnMouseExit() {
		SwordBlocker.SwordBlock=0;
		ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
	}

    IEnumerator OpenTownGate(){
        ActionDisplay.SetActive (false);
		ActionText.SetActive (false);
        gameObject.GetComponent<BoxCollider>().enabled=false;
        LeftGate.GetComponent<Animation>().Play("LeftGateOpenAnim");
        RightGate.GetComponent<Animation>().Play("RightGateOpenAnim");
        yield return new WaitForSeconds(12);
        gameObject.GetComponent<BoxCollider>().enabled=true;
    }

}
