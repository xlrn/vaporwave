using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour {
    public string defenseInput = "Def1";
    private Animator anim;
    private bool isDefending = false;

	// Use this for initialization
	void Start () {
        anim = gameObject.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
       
            bool isDefending = Input.GetKey("q");
            anim.SetBool("isDefending", isDefending);


	}

    void Defense() {



    }
}
