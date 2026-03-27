using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiLayerSpawner : MonoBehaviour
{
    
    public Transform[] spawnPoints; 
    public GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnPlayer()
    {
        // Select a random layer/point (0 or 1)
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform selectedSpawn = spawnPoints[randomIndex];

        // Instantiate at the chosen layer's position and rotation
        Instantiate(playerPrefab, selectedSpawn.position, selectedSpawn.rotation);
    }
}
