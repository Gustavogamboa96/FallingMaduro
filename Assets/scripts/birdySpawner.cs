using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdySpawner : MonoBehaviour {
    public int numToSpawn;
    public GameObject bird;
    public float spawnTime;
	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnBirdy", spawnTime, spawnTime);
	}
	

    void SpawnBirdy()
    {
        int spawned = 0;
        

        while(spawned< numToSpawn)
        {
            Vector2 position = new Vector2(Random.Range(-8.03f, 8.03f), 5.97f);
            spawned++;
            Instantiate(bird, position, Quaternion.identity);
        } 
    }

    
}
