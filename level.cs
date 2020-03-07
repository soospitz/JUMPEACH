using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level : MonoBehaviour {

    public GameObject platformPrefab;
    public GameObject platformPrefabB;
    public GameObject platformPrefabD;

    public int numberOfPlatform = 150;
    public int numberOfPlatform_B = 25;
    public int numberOfPlatform_D = 50;
    public float levelWidth = 3f;
    public float minY = .5f;
    public float maxY = 1.5f;
    public float minY_B = 5f;
    public float maxY_B = 5f;
    public float minY_D = .5f;
    public float maxY_D = 1.5f;

   
    void Start()
    { 

        Vector3 spawnPosition = new Vector3();
        Vector3 spawnPositionB = new Vector3();
        Vector3 spawnPositionD = new Vector3();

        //Cloud
        for (int i = 0; i < numberOfPlatform; i++)
        {

            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }

        //Boost Cloud
        for (int i = 0; i < numberOfPlatform_B; i++)
        {
            spawnPositionB.y += Random.Range(minY_B, maxY_B);
            spawnPositionB.x = Random.Range(-levelWidth, levelWidth);

            Instantiate(platformPrefabB, spawnPositionB, Quaternion.identity);
        }

        //Die Cloud
        for (int i = 0; i < numberOfPlatform_D; i++)
        {
            spawnPositionD.y += Random.Range(minY_D, maxY_D);
            spawnPositionD.x = Random.Range(-levelWidth, levelWidth);

            Instantiate(platformPrefabD, spawnPositionD, Quaternion.identity);
        }


       


    }
}
