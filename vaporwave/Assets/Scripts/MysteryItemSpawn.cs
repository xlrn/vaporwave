using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryItemSpawn : MonoBehaviour {

    private float timeInterval = 15f;
    private float timeDelay = 3f;
    public GameObject[] mysteryItems;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnItem", timeDelay, timeInterval);	
	}

    void SpawnItem() {
            float x = Mathf.Round(Random.Range(0, mysteryItems.Length));
            Instantiate(mysteryItems[(int)x], randomPosition(), Quaternion.identity);
                   
    }

    Vector3 randomPosition() {
        float x = Random.Range(-6, 6);
        float y = Random.Range(-4, 4);
        return new Vector3(x, y, 0);

    }

}
