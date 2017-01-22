using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headrolling : MonoBehaviour {
	public float myspeed;
	private float startingY;

	// Use this for initialization
	void Start () {
		//Vector3 rightVector = new Vector3 (1,0,0);

		//print ("hi i'm trump");
		startingY = transform.position.y;
	}

	// Update is called once per frame
	void Update () {


		transform.position += Vector3.right * myspeed * Time.deltaTime;
		float newY =  5 * Mathf.Sin (transform.position.x);
		Vector3 mypos = transform.position;
		mypos.y = newY + startingY;
		transform.position = mypos;

		transform.Rotate (7*Vector3.forward);

		if (transform.position.x > 20) {
			Destroy (gameObject);
			//print ("trump was destroyed :/");
		}
	}
}
