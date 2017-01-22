using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour {


    public string BackgroundMusicAudio;

    // Use this for initialization
    void Start () {
        SoundManager.Play(BackgroundMusicAudio);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
