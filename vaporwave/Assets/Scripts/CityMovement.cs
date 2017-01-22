using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityMovement : MonoBehaviour {

    public bool goingUp = false;
    public int speed = 4;

	
	// Update is called once per frame
	void Update () {

        if (goingUp)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }

    }



    void OnCollisionEnter2D(Collision2D coll)
    {
        Collider2D collObj = coll.gameObject.GetComponent<Collider2D>();
        Collider2D gameObj = gameObject.GetComponent<Collider2D>();

        if (coll.gameObject.tag == "top")
        {
            goingUp = false;
        }
        else if (coll.gameObject.tag == "bottom")
        {
            goingUp = true;
        }
        else {
            Physics2D.IgnoreCollision(collObj, gameObj);
        }



    }
}
