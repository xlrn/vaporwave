using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class startMenuScript : MonoBehaviour {

	public Button startText;
	public Button exitText;

	void Start () {
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}


	public void StartGame () { // Play button
		SceneManager.LoadScene (1); // "1" is the second scene in our game
	}

	public void ExitGame () {
		Application.Quit(); //this will quit our game. Note this will only work after building the game
	}

}
