using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10;
    private float xMovement;
    private float yMovement;
    private Rigidbody2D rb;
    public string horizontalControl = "Horiz_P1";
    public string verticalControl = "Vert_P1";

    private Animator anim;

    // Use this for initialization
    void Start () {

        rb = GetComponent<Rigidbody2D>();
         anim = gameObject.GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (anim.GetBool("isDefending"))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }
        else {
            xMovement = Input.GetAxisRaw(horizontalControl);
            yMovement = Input.GetAxisRaw(verticalControl);
            GetComponent<Rigidbody2D>().velocity = new Vector2(xMovement * speed, yMovement * speed);
            if (xMovement != 0 || yMovement != 0)
            {
                anim.SetBool("isWalking", true);
            }
            else {
                anim.SetBool("isWalking", false);
            }
        }

    }
}
