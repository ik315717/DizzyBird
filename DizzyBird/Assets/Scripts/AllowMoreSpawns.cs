using UnityEngine;
using System.Collections;

public class AllowMoreSpawns : MonoBehaviour {

	public bool allowmorespawns = true;
	
	// When colliding with another 2D collider, destroy that object
	void OnTriggerEnter2D(Collider2D other)
	{		
		// Destroy object's parent if it has one, else just destroy object
		if (other.gameObject.transform.parent)
			allowmorespawns = false;
		else
			allowmorespawns = true;
	}
}
