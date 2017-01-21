using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryItemSpawn : MonoBehaviour {

    public float timeInterval = 0.1f;
    public float timeDelay = 0.2f;
    public GameObject mysteryItem;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnItem", timeDelay, timeInterval);	
	}

    void SpawnItem() {
        Instantiate(mysteryItem, randomPosition(), Quaternion.identity);
    }

    Vector3 randomPosition() {
        float x = Random.Range(-8, 8);
        float y = Random.Range(-4, 4);
        return new Vector3(x, y, 0);

    }

}
