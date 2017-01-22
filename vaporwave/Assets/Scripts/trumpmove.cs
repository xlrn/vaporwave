using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trumpmove : MonoBehaviour {
	public float myspeed;

	// Use this for initialization
	void Start () {
		//Vector3 rightVector = new Vector3 (1,0,0);

		print ("hi i'm trump");
	}
	
	// Update is called once per frame
	void Update () {


		transform.position += Vector3.right * myspeed * Time.deltaTime;
		float newY = Mathf.Sin (transform.position.x);
		Vector3 mypos = transform.position;
		mypos.y = newY;
		transform.position = mypos;

		if (transform.position.x > 20) {
			Destroy (gameObject);
			print ("trump was destroyed :/");
		}
	}
}
