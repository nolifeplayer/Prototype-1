using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OppositeCarMover : MonoBehaviour
{
    
    public float carSpeed = 10f; // Adjustable speed in the Inspector
    public float destroyZPosition = 0; // Position where the car is destroyed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the car along its forward axis (adjust rotation in Editor if needed)
        transform.Translate(Vector3.forward * carSpeed * Time.deltaTime);

        // Destroy the car if it goes too far behind the player (assuming player moves forward)
        if (transform.position.z < destroyZPosition)
        {
            Destroy(gameObject);
        }
    }
}
