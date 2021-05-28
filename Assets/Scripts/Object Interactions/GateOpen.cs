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
	public GameObject Enemies;

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
				Enemies.SetActive(true);
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
        LeftGate.GetComponent<Animation>().Play("LeftGatePivotAnim");
        RightGate.GetComponent<Animation>().Play("RightGatePivotAnim");
        yield return new WaitForSeconds(9.5f);
        gameObject.GetComponent<BoxCollider>().enabled=true;
    }

}
