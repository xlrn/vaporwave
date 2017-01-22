using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class endMenuScript : MonoBehaviour {

	public Button playAgainText;
	public Button exitText;

	void Start () {
		playAgainText = playAgainText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
	}
		
	public void PlayAgain () { // Play button
		SceneManager.LoadScene (1); // "1" is the second scene in our game
	}

	public void ExitGame () { // "2" to differentiate with start menu 
		Application.Quit(); //this will quit our game. Note this will only work after building the game
	}

}
