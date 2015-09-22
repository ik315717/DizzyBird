/************************************************
** Destroyer Script
** This script detects collisions between the destroyer object
** and any generated platforms that have exited the screen and
** destroys the platforms once they're no longer needed.
*************************************************/
using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {

	// When colliding with another 2D collider, destroy that object
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player") 
		{
			// Faster to pass in scene number rather than evaluate a scene's string name
			// Scene number can be viewed in build settings
			Application.LoadLevel("GameOverScene");
			return;
		}

		// Destroy object's parent if it has one, else just destroy object
		if (other.gameObject.transform.parent)
			Destroy (other.gameObject.transform.parent.gameObject);
		else
			Destroy (other.gameObject);
	}


}
