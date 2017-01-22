using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceField : MonoBehaviour {
    
    public GameObject forceField;
    private GameObject newForceField;
    private GameObject player;
    private float x;
    private float y;
	private float originalx, originaly;

    // Use this for initialization
    void Start () {
		originalx = player.GetComponent<BoxCollider2D>().size.x;
		originaly = player.GetComponent<BoxCollider2D>().size.y;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player = other.gameObject;
            x = player.GetComponent<BoxCollider2D>().size.x;
            y = player.GetComponent<BoxCollider2D>().size.y;
            newForceField = Instantiate(forceField);
            newForceField.transform.parent = player.transform;
            newForceField.transform.position = player.transform.position;
            player.GetComponent<BoxCollider2D>().size = new Vector2(x * 2, y * 2);
            Invoke("removeForceField", 3.0f);
            this.gameObject.SetActive(false);
            Destroy(this.gameObject, 6.0f);
        }
    }

    void removeForceField() {
        player.GetComponent<BoxCollider2D>().size = new Vector2(originalx, originaly);
        Destroy(newForceField); 
    }
}
