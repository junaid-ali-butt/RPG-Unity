﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour {

	public static int HealthValue;
	public int InternalHealth;
	public GameObject Heart1;
	public GameObject Heart2;
	public GameObject Heart3;


	void Start () {
		HealthValue = 1;
	}
	

	void Update () {
		InternalHealth = HealthValue;
		if (HealthValue<=0) {
			SceneManager.LoadScene(1);
		}
		if (HealthValue == 1) {
			Heart1.SetActive (true);
			Heart2.SetActive (false);
		}
		if (HealthValue == 2) {
			Heart2.SetActive (true);
			Heart3.SetActive (false);
		}
		if (HealthValue == 3) {
			Heart3.SetActive (true);
		}

	}
}