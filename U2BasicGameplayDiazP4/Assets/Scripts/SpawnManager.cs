using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;


    private float spawnRangeX = 10;
    private float spawnRangeZ = 12;
    private float spawnPosZ = 20;
    private float spawnPosX = 20;

    private float startDelay = 2;
    private float spawnInterval = 4f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

        Vector3 spawnPos2 = new Vector3(Random.Range(0, spawnRangeX), 0, -spawnPosZ);
        Vector3 rotation = new Vector3(0, 180, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos2, Quaternion.Euler(rotation));

        Vector3 spawnPos3 = new Vector3(spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Vector3 rotation2 = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos3, Quaternion.Euler(rotation2));

        Vector3 spawnPos4 = new Vector3(-spawnPosX, 0, Random.Range(-spawnRangeZ, spawnRangeZ));
        Vector3 rotation3 = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos4, Quaternion.Euler(rotation3));
    }
}
