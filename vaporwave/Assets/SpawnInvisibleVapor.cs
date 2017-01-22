using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnInvisibleVapor : MonoBehaviour {

    public GameObject myinvisobject;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        
    }



    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            Instantiate(myinvisobject);
            myinvisobject.gameObject.GetComponent<VaporScript>().dostuff = true;
            //myinvisobject.gameObject.GetComponent<VaporScript>().mytimer = Time.time;
            //myinvisobject.gameObject.GetComponent<VaporScript>().counter = 0;
            Invoke("TurnOffTrump", 7.5f);
            this.gameObject.SetActive(false);
            Destroy(this.gameObject, 10.0f);
        }
    }

    void TurnOffTrump() {
        Destroy(myinvisobject);
    }


}
