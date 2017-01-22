using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour {
    public string defenseInput;
    private Animator anim;
    private bool isDefending = false;
    public Collider2D defenseTrigger;
    private bool playerHurt = false;
    Renderer rend;

	// Use this for initialization

    
	void Awake () {
        anim = gameObject.GetComponent<Animator>();
        rend = GetComponent<Renderer>();

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


    void OnCollisionEnter2D(Collision2D coll) {
        if (coll.gameObject.tag == "wave" && !isDefending && !playerHurt)
        {
            StartCoroutine(hurtPlayer(10,0.09f));


        }




        }




    IEnumerator hurtPlayer(int numBlinks, float seconds)
    {

        playerHurt = true;

        for (int i = 0; i < numBlinks; i++)
        {            
            rend.enabled = !rend.enabled;

            yield return new WaitForSeconds(seconds);
        }

        rend.enabled = true;
        playerHurt = false;



    }
}
