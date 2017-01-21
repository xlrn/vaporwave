using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createwave : MonoBehaviour {

	public float speed;
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public GameObject iObj;

	private float nextFire;

	void Update ()
	{
		if (Input.GetButton("Fire1") && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			iObj = (GameObject) Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}




}