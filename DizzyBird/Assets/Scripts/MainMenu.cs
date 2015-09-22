using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

    private float ButtonWidth, ButtonHeight = 0.0f;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    void OnGUI()
    {
        ButtonHeight = Screen.height / 10.0f;
        ButtonWidth = Screen.width / 3.0f;
        GUI.skin.button.fontSize = 30;
        if (GUI.Button(new Rect(Screen.width/2.0f - ButtonWidth/2.0f, Screen.height/2.0f, ButtonWidth, ButtonHeight), "Play Endless Runner!"))
            Application.LoadLevel("LevelScene");
    }
}
