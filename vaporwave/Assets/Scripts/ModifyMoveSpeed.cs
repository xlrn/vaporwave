using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModifyMoveSpeed : MonoBehaviour {

    private float modifier = 3;
    private PlayerMovement playerMovementScript;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Player") {
            playerMovementScript = other.gameObject.GetComponent<PlayerMovement>();
            playerMovementScript.speed = playerMovementScript.speed * modifier;
            Invoke("removeModifier", 4.0f);
        }
    }

    void removeModifier() {
        playerMovementScript.speed = playerMovementScript.speed / modifier;
    }
}
