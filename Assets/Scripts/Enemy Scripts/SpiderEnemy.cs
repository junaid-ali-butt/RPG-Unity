using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemy : MonoBehaviour
{
    public int EnemyHealth = 10;

	void DeductPoints (int DamageAmount) {
		EnemyHealth -= DamageAmount;
	}
    
	void Update () {
		if (EnemyHealth <= 0) {
			StartCoroutine (DeathSpider ());
		}
	}
	IEnumerator DeathSpider () {
		yield return new WaitForSeconds (0.5f);
		Destroy (gameObject);
	}
}
