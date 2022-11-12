using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SwitchCamera : MonoBehaviour
{
    public List<Camera> Cameras;

    // Start is called before the first frame update
    void Start()
    {
        EnableCamera(0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            EnableCamera(0);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha2)){
            EnableCamera(1);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha3)){
            EnableCamera(2);
        }
        else if(Input.GetKeyDown(KeyCode.Alpha4)){
            EnableCamera(3);
        }
    }

    void EnableCamera(int n)
    {
        // disable each of the cameras
        Cameras.ForEach(cam => cam.enabled = false);
        // Cameras.ForEach(cam => cam.depth = 0);
        // enable the selected camera
        Cameras[n].enabled = true;
        // Cameras[n].depth = 1;
    }
}
