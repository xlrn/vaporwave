using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayVideo : MonoBehaviour {

	public MovieTexture movie;
	RawImage rawImageComp;

	void Start () {
		rawImageComp = GetComponent<RawImage> ();
		PlayClip ();
		StartCoroutine(WaitAndLoad(3f, "end-menu")); // Goes to end-menu when the video ends  
	}
	

	void PlayClip () {
		rawImageComp.texture = movie;
		movie.Play ();
	}


	private IEnumerator WaitAndLoad(float value, string scene) {
		yield return new WaitForSeconds(value);
		SceneManager.LoadScene (scene);
	}

}
