using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab; 
    public int numberOfPlatforms = 200; 

    void Start()
    {
        SpawnPlatforms();
    }

    void SpawnPlatforms()
    {
        float xPosition = 0.4299906f;
        float zPosition = -0.2444329f;

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            Vector3 spawnPosition = new Vector3(xPosition, i - 0.004f, zPosition); // Spawns downward  
            Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        }
    }
}

