using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingmove : MonoBehaviour {

	public float speed;

	void Update ()
	{
		
		transform.position += Vector3.left * speed * Time.deltaTime;
	}


	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.tag == "wave" || coll.gameObject.tag == "cities" ) 
		{
			Destroy (this.gameObject);
		}


	}
}
