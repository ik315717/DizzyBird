using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] platforms;
	public float spawnMin = 1;
	public float spawnMax = 2;
    public GameObject spawnObject;

	// Use this for initialization
	void Start () 
	{
        // Random object, at spawnobjects position, with normal rotation

        Instantiate(platforms[Random.Range(0, platforms.Length)], transform.position + new Vector3(0,1,0), Quaternion.identity); 
	}

    void Update()
    {
        if (spawnObject.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().AllowSpawn == true)
        {
            Spawn();
            spawnObject.GetComponent<UnityStandardAssets._2D.PlatformerCharacter2D>().AllowSpawn = false;
        }
    }

	// Spawn platform objects
	public void Spawn() 
	{
        Instantiate(platforms[Random.Range(0, platforms.Length)], transform.position + new Vector3(0, 1, 0), Quaternion.identity);
    }

}

