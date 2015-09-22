using UnityEngine;

public class GameOverScript : MonoBehaviour {

	int score = 0;
    private float GameOverX, GameOverY, GameOverWidth, GameOverHeight = 0.0f;
    private float ButtonX, ButtonY, ButtonWidth, ButtonHeight = 0.0f;
    private float ScoreX, ScoreY, ScoreWidth, ScoreHeight = 0.0f;

	// Use this for initialization
	void Start () 
	{
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        score = PlayerPrefs.GetInt ("score");
	}

	void OnGUI()
	{
        ButtonHeight = Screen.height / 4.0f;
        ButtonWidth = Screen.width / 4.0f;
        ButtonX = Screen.width / 2.0f - ButtonWidth / 2.0f;
        ButtonY = Screen.height / 3.0f;

        if (GUI.Button (new Rect (ButtonX, ButtonY, ButtonWidth, ButtonHeight), "Retry?"))
			Application.LoadLevel (0);

        GameOverWidth = Screen.width / 2f;
        GameOverHeight = Screen.height / 10.0f;
        GameOverX = Screen.width / 2.0f - GameOverWidth / 2.0f;
        GameOverY = ButtonY - 2.0f * GameOverHeight;

        GUI.skin.button.fontSize = 50;
        GUI.Label(new Rect(GameOverX, GameOverY, GameOverWidth, GameOverHeight), "GAME OVER");

        ScoreHeight = Screen.height / 10.0f;
        ScoreWidth = Screen.width / 2.0f;
        ScoreX = GameOverX;
        ScoreY = ButtonY - GameOverHeight;

        GUI.Label(new Rect(ScoreX, ScoreY, ScoreWidth, ScoreHeight), "Score: " + score);
    }

}
