using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Delay audio because clip is laggy
public class TrumpAudio : MonoBehaviour {

	public AudioSource myAudio;
	// Use this for initialization
	void Start () {
		StartCoroutine(PlaySoundAfterDelay(myAudio, 0.5f)); //Delay audio cuz video lags so much 
	}

	IEnumerator PlaySoundAfterDelay(AudioSource audioSource, float delay)
	{
		if (audioSource == null){ 
			//Debug.Log("Audio Null"); 
			yield break;
		} else { 
			//Debug.Log("Audio Not Null"); 
			yield return new WaitForSeconds(delay); 
			audioSource.Play();
		}
	}
}
