using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryItemSpawn : MonoBehaviour {

    public float timeInterval = 3f;
    public float timeDelay = 2f;
    public GameObject mysteryItem;
    public int amount;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnItem", timeDelay, timeInterval);	
	}

    void SpawnItem() {
        if (amount < 3)
        {
            Instantiate(mysteryItem, randomPosition(), Quaternion.identity);
            amount++;
        }
    }

    Vector3 randomPosition() {
        float x = Random.Range(-8, 8);
        float y = Random.Range(-4, 4);
        return new Vector3(x, y, 0);

    }

}
