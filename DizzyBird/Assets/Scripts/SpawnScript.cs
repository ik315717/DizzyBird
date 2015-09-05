using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] platforms;
	public float spawnMin = 1;
	public float spawnMax = 2;

	// Use this for initialization
	void Start () 
	{
		Spawn (); // Start the Spawn function 
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		CancelInvoke ("Spawn");
		//Spawn();
	}
	
	// Spawn platform objects
	void Spawn() 
	{
			// Random object, at spawnobjects position, with normal rotation
			Instantiate(platforms[Random.Range(0, platforms.Length)], transform.position + new Vector3(0,1,0), Quaternion.identity);
			Invoke("Spawn", Random.Range(spawnMin, spawnMax)); // Spawn randomly between two time values (in seconds)
	}

}

