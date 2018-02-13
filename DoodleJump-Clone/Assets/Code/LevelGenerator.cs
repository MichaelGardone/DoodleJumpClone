using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    public GameObject platformPrefab;

    public int numOfPlatforms;
    public float levelWidth = 3f;
    public float minimumY = 0.2f;
    public float maximumY = 1.5f;

	// Use this for initialization
	void Start () {

        Vector3 spawnPosition = new Vector3();

        for(int i=0; i < numOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minimumY, maximumY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

	}
}
