using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createwave : MonoBehaviour {

	public float speed;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public GameObject iObj;
    public bool isPlayer1;
    public string fireKey;


	private float nextFire;

	void FixedUpdate ()
	{
		if (Input.GetKey(fireKey) && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			iObj = (GameObject) Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            
        }
        


	}


}