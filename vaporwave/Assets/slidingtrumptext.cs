using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slidingtrumptext : MonoBehaviour {

	private float myspeed;

	// Use this for initialization
	void Start () {
		myspeed = Random.Range (5,10);
	}

	// Update is called once per frame
	void Update () {


		transform.position += Vector3.right * myspeed * Time.deltaTime;


		if (transform.position.x > 20) {
			Destroy (gameObject);
			print ("trump was destroyed :/");
		}
	}
}
