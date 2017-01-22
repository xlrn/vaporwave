using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderScript : MonoBehaviour {

 

    void OnCollisionEnter2D(Collision2D coll) {
      Collider2D wall  = gameObject.GetComponent<Collider2D>();
        Collider2D collObj = coll.gameObject.GetComponent<Collider2D>();
        if (coll.gameObject.tag == "wave") {
            Physics2D.IgnoreCollision(collObj , wall);

        }
            
           // ob.isTrigger = false;
 

    }
}
