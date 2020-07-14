using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HordeSpawn : MonoBehaviour
{
    public GameObject Grunt;
    public GameObject Soldier;
    public GameObject Comander;

    public Vector3 spawnCorner1;
    public Vector3 spawnCorner2;

    private int totalSpawned = 1;

    public float spawnTimer = 10.0f;
    private float startSpawnTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        startSpawnTimer = spawnTimer;
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0) 
        {
            Spawn();
            spawnTimer = startSpawnTimer;
        }

    }
    private void Spawn() 
    {
        if (totalSpawned % 10 == 0)
        {
            Instantiate(Comander, new Vector3(Random.Range(spawnCorner1.x, spawnCorner2.x), 5, Random.Range(spawnCorner2.z, spawnCorner2.z)), Quaternion.identity);
        }
        else if (totalSpawned % 5 == 0)
        {
            Instantiate(Soldier, new Vector3(Random.Range(spawnCorner1.x, spawnCorner2.x), 2, Random.Range(spawnCorner2.z, spawnCorner2.z)), Quaternion.identity);
        }
        else 
        {
            Instantiate(Grunt, new Vector3(Random.Range(spawnCorner1.x, spawnCorner2.x), 1, Random.Range(spawnCorner2.z, spawnCorner2.z)), Quaternion.identity);
        }
        totalSpawned++;
    }
}
