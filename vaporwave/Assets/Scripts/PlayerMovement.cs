using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    private float xMovement;
    private float yMovement;
    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        xMovement = Input.GetAxisRaw("Horizontal");
        yMovement = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(xMovement * speed, yMovement * speed);

    }
}
