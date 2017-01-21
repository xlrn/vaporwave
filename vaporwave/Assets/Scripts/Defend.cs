using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour {
    public string defenseInput;
    private Animator anim;
    private bool isDefending = false;
    public Collider2D defenseTrigger;

	// Use this for initialization
	void Awake () {
        anim = gameObject.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
       
        if (Input.GetKey(defenseInput))
        {
            defenseTrigger.enabled = true;
            anim.SetBool("isDefending", true);
        }
        else {
            defenseTrigger.enabled = false;
            anim.SetBool("isDefending", false);
        }
    }

    void Defense() {



    }
}
