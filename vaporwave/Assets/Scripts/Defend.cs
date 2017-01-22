using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend : MonoBehaviour {
    public string defenseInput;
    private Animator anim;
    private bool isDefending = false;
    public Collider2D defenseTrigger;
    private bool playerHurt = false;
    private Renderer rend;
    private Rigidbody2D rb;

	// Use this for initialization

    
	void Awake () {
        anim = gameObject.GetComponent<Animator>();
        rend = GetComponent<Renderer>();
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {
       
        if (Input.GetKey(defenseInput))
        {
            isDefending = true;
            defenseTrigger.enabled = true;
            anim.SetBool("isDefending", true);
        }
        else {
            isDefending = false;
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
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
        playerHurt = true;

        for (int i = 0; i < numBlinks; i++)
        {            
            rend.enabled = !rend.enabled;

            yield return new WaitForSeconds(seconds);
        }
        rb.constraints = RigidbodyConstraints2D.None;

        rend.enabled = true;
        playerHurt = false;



    }
}
