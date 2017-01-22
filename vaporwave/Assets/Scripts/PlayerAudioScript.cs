using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioScript : MonoBehaviour {


    public string PlayerAudioSFX;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space")) {
            SoundManager.Play(PlayerAudioSFX);
        }
        	
	}
    
    

}
