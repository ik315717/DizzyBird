using UnityEngine;
using System.Collections;

public class CameraRunnerScript : MonoBehaviour {
	
	public Transform player;

    void Start()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void Update() 
	{
		transform.position = new Vector3 (player.position.x + 6, 0, -10);
	}
}
