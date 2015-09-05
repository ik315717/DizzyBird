using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	int score = 0;

	// Use this for initialization
	void Start () 
	{
		score = PlayerPrefs.GetInt ("Score");
	}

	void OnGUI()
	{
		GUI.Label (new Rect (Screen.width / 3, 50, 80, 30), "GAME OVER");

		GUI.Label(new Rect(Screen.width/3, 300, 80, 30), "Score: " + score);

		if (GUI.Button (new Rect (Screen.width/4, Screen.height/4, 400, 400), "Retry?"))
			Application.LoadLevel (0);
	}

}
