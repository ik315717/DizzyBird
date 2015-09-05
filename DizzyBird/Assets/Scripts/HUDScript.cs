using UnityEngine;
using System.Collections;

public class HUDScript : MonoBehaviour {
	
	public static bool jumpbuttonpressed = false;
	float score = 0;

	// Update is called once per frame
	void Update () 
	{

	}

	public void ChangeScore( int amount)
	{
		score += amount;
	}

	void OnGUI()
	{
		// 10, 10 puts score in upper left corner
		#warning For use on many different devices, use "screen" to determine where the score should be depending on devices screen size
		GUI.Label(new Rect(10, 10, 100, 30), "Score: " + score);
	}

	// When HUD script is disabled (when you die)
	void OnDisable()
	{
		// Pass score value onto next scene
		#warning This should be revised as it's not very secure (easily modifiable)
		PlayerPrefs.SetInt ("Score", (int)score);
	}
}
