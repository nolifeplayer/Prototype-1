using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    public GameObject carPrefab; // Drag your car Prefab here in the Inspector
    public Transform[] spawnPoints; // An empty GameObject to mark the spawn location
    // The delay in seconds before the first spawn
    public float startDelay = 2.0f;

    // The repeat rate in seconds between subsequent spawns
    public float repeatRate = 3.0f;
    
   
    // Start is called before the first frame update
    void Start()
    {
        
        InvokeRepeating("SpawnCar", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCar()
    {
        // Check if there are any spawn points assigned
        if (spawnPoints.Length == 0)
        {
            Debug.LogError("No spawn points assigned to the spawner!");
            return;
        }

        // Randomly select an index from the spawnPoints array
        int randomIndex = Random.Range(0, spawnPoints.Length);
        // Note: Random.Range with 2 int parameters returns a value from a range that includes the min (0) but excludes the max (spawnPoints.Length), which is perfect for array indices.



        // Instantiate the car prefab at the selected position and rotation
        Instantiate(carPrefab, spawnPoints[randomIndex].position, carPrefab.transform.rotation);

       
    }

}
