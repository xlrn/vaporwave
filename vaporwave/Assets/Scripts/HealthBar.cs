using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class HealthBar : MonoBehaviour {
	 

	public float maxHp;
	public float currentHp;
	public bool isPlayer1;

    public void TakeDamage() {
		isPlayer1 = false;
		currentHp -= 5f;
		if (currentHp <= 0f) {
			currentHp = 0f;
		}
		transform.localScale = new Vector3 ((currentHp / maxHp), 1, 1);	
	}
}


