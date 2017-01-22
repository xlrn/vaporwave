using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingmove : MonoBehaviour {

	public float speed;
    public bool isPlayer1;

    void Update ()
	{
        if (isPlayer1)
        {
             transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
        if (coll.gameObject.tag == "City" || coll.gameObject.tag == "Player" || coll.gameObject.tag == "wave")
        {
            Destroy (gameObject);
        }
        else {
        }



	}
}
