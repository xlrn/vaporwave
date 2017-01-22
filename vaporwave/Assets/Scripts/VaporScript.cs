using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VaporScript : MonoBehaviour {
	private Camera lecamera;
	public GameObject trumpObject;
	public GameObject stoneObject;
	public GameObject textObject;
	private Transform trumpTransform;

	public float mytimer = -100;
    public bool dostuff = false;
	public float counter;

	void Start(){
        lecamera = Camera.main;
        trumpTransform = lecamera.transform;
        bool dostuff = false;
		mytimer = Time.time;

		counter = 0;

    }

	// Update is called once per frame
	void Update () {
		float currentTime = Time.time;


        if (currentTime - mytimer < 7)
			lecamera.depth = 1;
		else
			lecamera.depth = -2;
		
	
		if (dostuff == true) {
			//print("I should be doing something");
			//print (Time.time);

			double testcon = mytimer + counter * 0.1;
			//print (testcon);

			if (mytimer + counter * 0.2 < currentTime) {
				//print (counter);

				//make trump
				Vector3 trumplocation = new Vector3 (-10,0,1);
				GameObject mytrumpObject = Instantiate(trumpObject, trumplocation, trumpTransform.rotation);
						
				//make stone head
				Vector3 sheadlocation = new Vector3 (-6,counter-5,1);
				GameObject myStoneHead = Instantiate (stoneObject, sheadlocation, trumpTransform.rotation);

				//spawn the trump text
				Vector3 textlocation = new Vector3(-10,Random.Range(-10,10),1);
				GameObject myTrumpText = Instantiate (textObject, textlocation, trumpTransform.rotation);
                print("created something" + Time.time);
				counter++;
			} 
			
			
		
			if(counter > 10)
				dostuff = false;

		}
		
	}


    

}
