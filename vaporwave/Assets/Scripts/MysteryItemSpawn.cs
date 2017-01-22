using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryItemSpawn : MonoBehaviour {

    private float timeInterval = 15f;
    private float timeDelay = 10f;
    public GameObject[] mysteryItems;
    public int amount = 0;

	// Use this for initialization
	void Start () {
        amount = 0;
        InvokeRepeating("SpawnItem", timeDelay, timeInterval);	
	}

    void SpawnItem() {
        if (amount < 3)
        {
            float x = Mathf.Round(Random.Range(0, mysteryItems.Length));
            Instantiate(mysteryItems[(int)x], randomPosition(), Quaternion.identity);
            amount++;
        }
    }

    Vector3 randomPosition() {
        float x = Random.Range(-6, 6);
        float y = Random.Range(-4, 4);
        return new Vector3(x, y, 0);

    }

}
