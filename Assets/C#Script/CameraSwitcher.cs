using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    
    public Camera aboveVehicleCam;
    public Camera driverSeatCam;
    // You can also use public GameObject to disable/enable the whole object.
    // Start is called before the first frame update
    void Start()
    {
        // Ensure only one camera is active at the start
        if (aboveVehicleCam != null)
        {
            aboveVehicleCam.enabled = true;
        }
        if (driverSeatCam != null)
        {
            driverSeatCam.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
         // Check for a key press (e.g., the 'C' key) to toggle cameras
        if (Input.GetKeyDown(KeyCode.C))
        {
            SwitchCameras();
        }
    }

    void SwitchCameras()
    {
        // Toggle the enabled state of both cameras
        if (aboveVehicleCam != null && driverSeatCam != null)
        {
            aboveVehicleCam.enabled = !aboveVehicleCam.enabled;
            driverSeatCam.enabled = !driverSeatCam.enabled;
        }
    }

}
